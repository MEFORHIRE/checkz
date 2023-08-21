/*
 * MATLAB Compiler: 4.13 (R2010a)
 * Date: Thu May 06 23:36:55 2010
 * Arguments: "-B" "macro_default" "-o" "Balance" "-W" "WinMain:Balance" "-T"
 * "link:exe" "-d" "C:\work\balanceproj\Balance\Balance\src" "-w"
 * "enable:specified_file_mismatch" "-w" "enable:repeated_file" "-w"
 * "enable:switch_ignored" "-w" "enable:missing_lib_sentinel" "-w"
 * "enable:demo_license" "-v" "C:\work\balanceproj\Balance\Balance.m" "-a"
 * "C:\work\balanceproj\Balance\ItemPrice.m" "-a"
 * "C:\work\balanceproj\Balance\Items.m" "-a"
 * "C:\work\balanceproj\Balance\ItemSales.m" 
 */

#include "mclmcrrt.h"

#ifdef __cplusplus
extern "C" {
#endif
const unsigned char __MCC_Balance_session_key[] = {
    '7', 'F', '1', '0', 'B', '0', 'A', '8', '9', 'C', 'B', '9', '3', '1', '4',
    '1', 'D', '9', '0', 'A', '4', '6', '0', 'B', 'F', 'A', '6', '6', '8', '0',
    '8', 'D', '9', '8', '5', '2', 'B', '4', '1', 'C', '9', 'D', '5', 'B', '3',
    '0', 'E', '3', 'D', '0', 'F', '9', '0', 'F', '7', '8', '1', 'D', 'D', 'C',
    'D', 'F', '3', 'D', '1', '8', '9', 'F', 'B', '4', '8', '6', 'E', '0', 'C',
    '7', '4', '6', '8', '0', '1', '7', 'D', 'F', '2', '6', 'E', '7', '9', 'E',
    '7', '5', '7', 'A', '5', '0', '0', '4', '3', '8', 'F', '3', '6', 'C', '9',
    'E', 'D', 'C', '6', '2', '7', '4', '8', '0', 'D', 'C', '1', '4', '9', 'D',
    'D', '0', '5', '7', 'C', '5', '7', '1', '5', '8', '9', '0', '8', '5', '1',
    '6', '8', '0', '2', '1', 'F', '1', 'E', 'D', '0', '1', 'F', 'C', '4', '8',
    '4', '3', 'C', '5', 'D', '1', '1', 'E', 'D', '4', 'C', '2', '8', '9', 'F',
    '0', '9', 'C', 'A', '0', 'D', 'B', '1', '9', '2', 'B', 'C', '0', '3', 'F',
    '3', '5', '0', '6', 'A', '9', '3', 'E', 'D', 'A', '5', '1', '4', '1', 'F',
    '2', 'F', '7', 'D', '1', '9', '8', '4', '8', 'D', '5', 'A', '0', '6', '1',
    '9', '7', 'A', 'E', '1', '9', '9', '4', '3', 'B', '4', '2', 'C', '1', 'C',
    '8', '0', 'E', '4', '5', 'E', '3', '5', '8', 'F', 'D', 'F', 'F', '1', '1',
    '8', '6', 'A', '8', '1', '7', '8', 'E', 'C', '3', '9', '7', 'B', '1', '7',
    '7', '\0'};

const unsigned char __MCC_Balance_public_key[] = {
    '3', '0', '8', '1', '9', 'D', '3', '0', '0', 'D', '0', '6', '0', '9', '2',
    'A', '8', '6', '4', '8', '8', '6', 'F', '7', '0', 'D', '0', '1', '0', '1',
    '0', '1', '0', '5', '0', '0', '0', '3', '8', '1', '8', 'B', '0', '0', '3',
    '0', '8', '1', '8', '7', '0', '2', '8', '1', '8', '1', '0', '0', 'C', '4',
    '9', 'C', 'A', 'C', '3', '4', 'E', 'D', '1', '3', 'A', '5', '2', '0', '6',
    '5', '8', 'F', '6', 'F', '8', 'E', '0', '1', '3', '8', 'C', '4', '3', '1',
    '5', 'B', '4', '3', '1', '5', '2', '7', '7', 'E', 'D', '3', 'F', '7', 'D',
    'A', 'E', '5', '3', '0', '9', '9', 'D', 'B', '0', '8', 'E', 'E', '5', '8',
    '9', 'F', '8', '0', '4', 'D', '4', 'B', '9', '8', '1', '3', '2', '6', 'A',
    '5', '2', 'C', 'C', 'E', '4', '3', '8', '2', 'E', '9', 'F', '2', 'B', '4',
    'D', '0', '8', '5', 'E', 'B', '9', '5', '0', 'C', '7', 'A', 'B', '1', '2',
    'E', 'D', 'E', '2', 'D', '4', '1', '2', '9', '7', '8', '2', '0', 'E', '6',
    '3', '7', '7', 'A', '5', 'F', 'E', 'B', '5', '6', '8', '9', 'D', '4', 'E',
    '6', '0', '3', '2', 'F', '6', '0', 'C', '4', '3', '0', '7', '4', 'A', '0',
    '4', 'C', '2', '6', 'A', 'B', '7', '2', 'F', '5', '4', 'B', '5', '1', 'B',
    'B', '4', '6', '0', '5', '7', '8', '7', '8', '5', 'B', '1', '9', '9', '0',
    '1', '4', '3', '1', '4', 'A', '6', '5', 'F', '0', '9', '0', 'B', '6', '1',
    'F', 'C', '2', '0', '1', '6', '9', '4', '5', '3', 'B', '5', '8', 'F', 'C',
    '8', 'B', 'A', '4', '3', 'E', '6', '7', '7', '6', 'E', 'B', '7', 'E', 'C',
    'D', '3', '1', '7', '8', 'B', '5', '6', 'A', 'B', '0', 'F', 'A', '0', '6',
    'D', 'D', '6', '4', '9', '6', '7', 'C', 'B', '1', '4', '9', 'E', '5', '0',
    '2', '0', '1', '1', '1', '\0'};

static const char * MCC_Balance_matlabpath_data[] = 
  { "Balance/", "$TOOLBOXDEPLOYDIR/", "work/balanceproj/Balance/",
    "$TOOLBOXMATLABDIR/general/", "$TOOLBOXMATLABDIR/ops/",
    "$TOOLBOXMATLABDIR/lang/", "$TOOLBOXMATLABDIR/elmat/",
    "$TOOLBOXMATLABDIR/randfun/", "$TOOLBOXMATLABDIR/elfun/",
    "$TOOLBOXMATLABDIR/specfun/", "$TOOLBOXMATLABDIR/matfun/",
    "$TOOLBOXMATLABDIR/datafun/", "$TOOLBOXMATLABDIR/polyfun/",
    "$TOOLBOXMATLABDIR/funfun/", "$TOOLBOXMATLABDIR/sparfun/",
    "$TOOLBOXMATLABDIR/scribe/", "$TOOLBOXMATLABDIR/graph2d/",
    "$TOOLBOXMATLABDIR/graph3d/", "$TOOLBOXMATLABDIR/specgraph/",
    "$TOOLBOXMATLABDIR/graphics/", "$TOOLBOXMATLABDIR/uitools/",
    "$TOOLBOXMATLABDIR/strfun/", "$TOOLBOXMATLABDIR/imagesci/",
    "$TOOLBOXMATLABDIR/iofun/", "$TOOLBOXMATLABDIR/audiovideo/",
    "$TOOLBOXMATLABDIR/timefun/", "$TOOLBOXMATLABDIR/datatypes/",
    "$TOOLBOXMATLABDIR/verctrl/", "$TOOLBOXMATLABDIR/codetools/",
    "$TOOLBOXMATLABDIR/helptools/", "$TOOLBOXMATLABDIR/winfun/",
    "$TOOLBOXMATLABDIR/winfun/NET/", "$TOOLBOXMATLABDIR/demos/",
    "$TOOLBOXMATLABDIR/timeseries/", "$TOOLBOXMATLABDIR/hds/",
    "$TOOLBOXMATLABDIR/guide/", "$TOOLBOXMATLABDIR/plottools/",
    "toolbox/local/", "$TOOLBOXMATLABDIR/datamanager/",
    "toolbox/compiler/", "toolbox/database/database/" };

static const char * MCC_Balance_classpath_data[] = 
  { "java/jar/toolbox/database.jar" };

static const char * MCC_Balance_libpath_data[] = 
  { "" };

static const char * MCC_Balance_app_opts_data[] = 
  { "" };

static const char * MCC_Balance_run_opts_data[] = 
  { "" };

static const char * MCC_Balance_warning_state_data[] = 
  { "off:MATLAB:dispatcher:nameConflict" };


mclComponentData __MCC_Balance_component_data = { 

  /* Public key data */
  __MCC_Balance_public_key,

  /* Component name */
  "Balance",

  /* Component Root */
  "",

  /* Application key data */
  __MCC_Balance_session_key,

  /* Component's MATLAB Path */
  MCC_Balance_matlabpath_data,

  /* Number of directories in the MATLAB Path */
  41,

  /* Component's Java class path */
  MCC_Balance_classpath_data,
  /* Number of directories in the Java class path */
  1,

  /* Component's load library path (for extra shared libraries) */
  MCC_Balance_libpath_data,
  /* Number of directories in the load library path */
  0,

  /* MCR instance-specific runtime options */
  MCC_Balance_app_opts_data,
  /* Number of MCR instance-specific runtime options */
  0,

  /* MCR global runtime options */
  MCC_Balance_run_opts_data,
  /* Number of MCR global runtime options */
  0,
  
  /* Component preferences directory */
  "Balance_B7F4CBA6DA496EDA2660E1E31EF2EC1F",

  /* MCR warning status data */
  MCC_Balance_warning_state_data,
  /* Number of MCR warning status modifiers */
  1,

  /* Path to component - evaluated at runtime */
  NULL

};

#ifdef __cplusplus
}
#endif


