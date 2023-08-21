classdef ItemPrice   < handle
    properties (SetAccess = private)
        itemlist;
        range;
    end;
    methods
        function u = ItemPrice(items_, range)
            u.itemlist = items_;
            u.range = range;
        end;
        
        function [ points, sql ] = PlotItemPrice(obj,conn)
            count = 1:obj.range;
            [points,sql] = PlotPrice(obj,conn);
            plot(count,points.y1,'b-',count,points.y2,'r-',count,points.y3,'k-',count,points.y4,'g-',count,points.y5,'m-',count,points.y6,'c-');
            legend(obj.itemlist);
            xlabel('Date');
            ylabel('Price');
            title('Price Range');            
        end;
        
        function [ points, sql ] = PlotPrice(obj,conn)
            for i = 1:length(obj.itemlist)
                t = strcat('y',num2str(i));
                [points.(t), sql] = PlotPrice_(obj,conn,i);
                points.(t) = fetchl(conn,points.(t), obj.range);
                points.(t) = cell2mat(points.(t).Data(:,2));
                if(length(points.(t)) < obj.range)
                    len = length(points.(t));
                    A = points.(t);
                    for j= len+1:obj.range
                        A = [A;[0]];
                    end;
                    points.(t) = A;
                end;
            end;
        end
        
        function [ curs, sql ] = PlotPrice_(obj,conn, item)            
            if(strcmp(obj.itemlist(item), ''))
                curs = exec(conn, 'select ceil(DATE_FORMAT(created,"%d")), price from txn where type=1 group by date(created) order by date(created) desc');
            else
                sql1 = 'select ceil(DATE_FORMAT(created,"%d")), sum(amount)/sum(qty) from txn where type=1 and item="';
                sql2 = '" group by date(created) order by date(created) desc';
                sql = strcat(sql1, obj.itemlist(item), sql2);
                curs = exec(conn,sql);
            end
        end
    end
end

