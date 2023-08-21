using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Drawing;
using System.IO;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows;
using System.Data.Common;

namespace CheckCasher.util
{
    class CheckHelper
    {
        public AxRANGERLib.AxRanger axRanger1;
        Button save;
        CashCheck cc;

        public System.Windows.Controls.Image front = null;
        public System.Windows.Controls.Image rear = null;

        
        public CheckHelper(CashCheck cc)
        {
            this.save = cc.savecustomer;
            this.cc = cc;
            this.axRanger1 = cc.axRanger1;
            ((System.ComponentModel.ISupportInitialize)(this.axRanger1)).BeginInit();
            this.front = cc.checkCapture;
            this.rear = cc.backCapture;
            System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(CheckCasher.Resources.CheckHelper));
            this.axRanger1.Enabled = true;
            this.axRanger1.Location = new System.Drawing.Point(360, 16);
            this.axRanger1.Name = "axRanger1";
            this.axRanger1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axRanger1.OcxState")));
            this.axRanger1.Size = new System.Drawing.Size(96, 93);
            this.axRanger1.TabIndex = 22;
            this.axRanger1.TransportSetItemOutput += new AxRANGERLib._DRangerEvents_TransportSetItemOutputEventHandler(this.axRanger1_TransportSetItemOutput);
            this.axRanger1.TransportNewItem += new System.EventHandler(this.axRanger1_TransportNewItem);
            this.axRanger1.TransportChangeOptionsState += new AxRANGERLib._DRangerEvents_TransportChangeOptionsStateEventHandler(this.axRanger1_TransportChangeOptionsState);
            this.axRanger1.TransportFeedingStopped += new AxRANGERLib._DRangerEvents_TransportFeedingStoppedEventHandler(this.axRanger1_TransportFeedingStopped);
            this.axRanger1.TransportItemInPocket += new AxRANGERLib._DRangerEvents_TransportItemInPocketEventHandler(this.axRanger1_TransportItemInPocket);
            this.axRanger1.TransportNewState += new AxRANGERLib._DRangerEvents_TransportNewStateEventHandler(this.axRanger1_TransportNewState);
            this.axRanger1.EndInit();
        }
               

        private void axRanger1_TransportChangeOptionsState(object sender, AxRANGERLib._DRangerEvents_TransportChangeOptionsStateEvent e)
        {
            if (e.previousState == (int)XportStates.TransportStartingUp)
            {
                axRanger1.SetGenericOption("OptionalDevices", "NeedImaging", "True");
                axRanger1.SetGenericOption("OptionalDevices", "NeedFrontImage1", "True");
                axRanger1.SetGenericOption("OptionalDevices", "NeedRearImage1", "True");
                axRanger1.SetGenericOption("OptionalDevices", "NeedFrontImage2", "False");
                axRanger1.SetGenericOption("OptionalDevices", "NeedRearImage2", "False");
                axRanger1.SetGenericOption("OptionalDevices", "NeedFrontImage3", "False");
                axRanger1.SetGenericOption("OptionalDevices", "NeedRearImage3", "False");
                axRanger1.SetGenericOption("OptionalDevices", "NeedFrontImage4", "False");
                axRanger1.SetGenericOption("OptionalDevices", "NeedRearImage4", "False");
                axRanger1.EnableOptions(); //enable job-related parameters
            }
        }
        private void axRanger1_TransportNewState(object sender, AxRANGERLib._DRangerEvents_TransportNewStateEvent e)
        {
            DisplayRangerState();
            if (e.currentState == (int)XportStates.TransportChangeOptions)
            {
                //save.IsEnabled = true;
            }
            else if (e.currentState == (int)XportStates.TransportReadyToFeed)
            {
                //save.IsEnabled = true;
            }
            else if (e.currentState == (int)XportStates.TransportShutDown)
            {
                //save.IsEnabled = false;
                //cmdStopFeeding.Enabled = false;
            }
        }
        public void DisplayRangerState()
        {
            //MessageBox.Show(axRanger1.GetTransportStateString());
        }
        private void axRanger1_TransportFeedingStopped(object sender, AxRANGERLib._DRangerEvents_TransportFeedingStoppedEvent e)
        {
            if (e.reason == (int)FeedingStoppedReasons.MainHopperEmpty)
            {
                //save.IsEnabled = true;
                
            }
        }
        private void axRanger1_TransportNewItem(object sender, System.EventArgs e)
        {
            int ItemID = axRanger1.GetItemID();
            txtNewItem = ItemID.ToString();
        }


        


        private void axRanger1_TransportSetItemOutput(object sender, AxRANGERLib._DRangerEvents_TransportSetItemOutputEvent e)
        {
            txtMICR = '"' + axRanger1.GetMicrText(1) + '"';
            //txtMICR = "d102100400d 40142475062280c";
            MICRParser mp = new MICRParser();
            MICR micr = mp.parseMicrString(txtMICR);           
            //string [] data = CheckUtil.readRangerMICR(txtMICR);
            if (verifyCompany(micr.getRtn(), micr.getOnUs()) > 0)                
            {
                cc.check.Text = micr.getSerialNumber() != null ? micr.getSerialNumber() : micr.getAuxOnUs();
                cc.routing.Text = micr.getRtn();
                cc.acct.Text = micr.getOnUs();
            }
            
            axRanger1.SetTargetLogicalPocket(1);
        }
        public int res = 0;
        private int verifyCompany(string routing, string acct)
        {
            DbDataReader rdr = DB.getInstance().ExecuteQuery(
                "select * from flagged where routing='" + routing + "' and account='" + acct + "'");
            
            if (rdr.Read())
            {
                MessageBox.Show("This company is blacklisted. Please scan a different check");
                res = -1;
                front.Source = null;
                rear.Source = null;
            }
            else
                res = 1;
            rdr.Close();
            
            DB.getInstance().close();
            return res;
        }

        
        public string txtInPocket = string.Empty;
        public string txtMICR = string.Empty;
        public string txtNewItem = string.Empty;

        private void axRanger1_TransportItemInPocket(object sender, AxRANGERLib._DRangerEvents_TransportItemInPocketEvent e)
        {
            if (res < 1) return;
            txtInPocket = e.itemId.ToString();            
            //MessageBox.Show(txtMICR);           
            int sizeFront;
            sizeFront = axRanger1.GetImageByteCount((int)Sides.TransportFront, (int)ImageColorTypes.ImageColorTypeBitonal);
            byte[] mybytesFront = new byte[sizeFront];
            IntPtr ptrFront = new IntPtr(axRanger1.GetImageAddress((int)Sides.TransportFront, (int)ImageColorTypes.ImageColorTypeBitonal));
            Marshal.Copy(ptrFront, mybytesFront, 0, sizeFront);
            System.IO.MemoryStream streamBitmapFront = new MemoryStream(mybytesFront);            
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.StreamSource = streamBitmapFront;
            bi.EndInit();
            
            front.Source = bi;
            int sizeRear;
            sizeRear = axRanger1.GetImageByteCount((int)Sides.TransportRear, (int)ImageColorTypes.ImageColorTypeBitonal);
            byte[] mybytesRear = new byte[sizeRear];
            IntPtr ptrRear = new IntPtr(axRanger1.GetImageAddress((int)Sides.TransportRear, (int)ImageColorTypes.ImageColorTypeBitonal));
            Marshal.Copy(ptrRear, mybytesRear, 0, sizeRear);
            System.IO.MemoryStream streamBitmapRear = new MemoryStream(mybytesRear);
            bi = new BitmapImage();            
            bi.BeginInit();
            bi.StreamSource = streamBitmapRear;
            bi.EndInit();
            rear.Source = bi;
            axRanger1.StopFeeding();

        }

        private enum XportStates
        {
            TransportShutDown = 0,
            TransportStartingUp = 1,
            TransportChangeOptions = 2,
            TransportEnablingOptions = 3,
            TransportReadyToFeed = 4,
            TransportFeeding = 5,
            TransportExceptionInProgress = 6,
            TransportShuttingDown = 7
        };
        private enum FeedingStoppedReasons
        {
            FeedRequestFinished = 0,
            MainHopperEmpty = 1,
            MergeHopperEmpty = 2,
            ManualDropEmpty = 3,
            FeedStopRequested = 4,
            ClearTrackRequested = 5,
            BlackBandItemDetected = 6,
            EndOfLogicalMicrofilmRoll = 7,
            ExceptionDetected = 8
        };
        private enum IQATestIDs
        {
            IQATest_UndersizeImage = 1,
            IQATest_OversizeImage = 2,
            IQATest_BelowMinCompressedSize = 3,
            IQATest_AboveMaxCompressedSize = 4,
            IQATest_FrontRearDimensionMismatch = 5,
            IQATest_HorizontalStreaks = 6,
            IQATest_ImageTooLight = 7,
            IQATest_ImageTooDark = 8,
            IQATest_CarbonStrip = 9,
            IQATest_FramingError = 10,
            IQATest_ExcessiveSkew = 11,
            IQATest_TornEdges = 12,
            IQATest_TornCorners = 13,
            IQATest_SpotNoise = 14
        };
        private enum IQATestStatus
        {
            IQATestStatus_NotTested = 0,
            IQATestStatus_DefectPresent = 1,
            IQATestStatus_DefectNotPresent = 2
        };
        private enum IQAResults
        {
            IQAResult_TestResult = 1
        };
        private enum IQAResults_UndersizeImage : int
        {
            UndersizeImage_ImageWidth = 2,
            UndersizeImage_ImageHeight = 3
        };
        private enum IQAResults_OversizeImage
        {
            OversizeImage_ImageWidth = 2,
            OversizeImage_ImageHeight = 3
        };
        private enum IQAResults_BelowMinCompressedSize
        {
            BelowMinCompressedSize_CompressedImageSize = 2,
            BelowMinCompressedSize_ImageResolution = 3
        };
        private enum IQAResults_AboveMaxCompressedSize
        {
            AboveMaxCompressedSize_CompressedImageSize = 2,
            AboveMaxCompressedSize_ImageResolution = 3
        };
        private enum IQAResults_FrontRearDimensionMismatch
        {
            FrontRearDimensionMismatch_WidthDifference = 2,
            FrontRearDimensionMismatch_HeightDifference = 3
        };
        private enum IQAResults_HorizontalStreaks
        {
            HorizontalStreaks_StreakCount = 2,
            HorizontalStreaks_ThickestStreak = 3,
            HorizontalStreaks_ThickestStreakLocation = 4
        };
        private enum IQAResults_ImageTooLight
        {
            ImageTooLight_BitonalBlackPixelPercent = 2
        };
        private enum IQAResults_ImageTooDark
        {
            ImageTooDark_BitonalBlackPixelPercent = 2
        };
        private enum IQAResults_FramingError
        {
            FramingError_TopEdge = 2,
            FramingError_LeftEdge = 3,
            FramingError_BottomEdge = 4,
            FramingError_RightEdge = 5
        };
        private enum IQAResults_ExcessiveSkew
        {
            ExcessiveSkew_Angle = 2
        };
        private enum IQAResults_TornEdges
        {
            TornEdges_LeftTearWidth = 2,
            TornEdges_LeftTearHeight = 3,
            TornEdges_BottomTearWidth = 4,
            TornEdges_BottomTearHeight = 5,
            TornEdges_RightTearWidth = 6,
            TornEdges_RightTearHeight = 7,
            TornEdges_TopTearWidth = 8,
            TornEdges_TopTearHeight = 9
        };
        private enum IQAResults_TornCorners
        {
            TornCorners_TopLeftTearWidth = 2,
            TornCorners_TopLeftTearHeight = 3,
            TornCorners_BottomLeftTearWidth = 4,
            TornCorners_BottomLeftTearHeight = 5,
            TornCorners_TopRightTearWidth = 6,
            TornCorners_TopRightTearHeight = 7,
            TornCorners_BottomRightTearWidth = 8,
            TornCorners_BottomRightTearHeight = 9
        };
        private enum IQAResults_SpotNoise
        {
            SpotNoise_AverageSpotNoiseCount = 2
        };
        private enum Sides
        {
            TransportFront = 0,
            TransportRear = 1,
        };
        private enum ImageColorTypes
        {
            ImageColorTypeUnknown = -1,
            ImageColorTypeBitonal = 0,
            ImageColorTypeGrayscale = 1,
            ImageColorTypeColor = 2
        };
        private bool UsingIQA;

        
    }
}
