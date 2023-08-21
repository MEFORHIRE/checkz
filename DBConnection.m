classdef DBConnection
    %UNTITLED Summary of this class goes here
    %   Detailed explanation goes here
    %   Currently supports SqlServer CE, MySql. Add more types, and handle
    %   fetch, close, exec methods.
    
    properties
        type;
        conn_;
    end
    
    methods
        function conn = DBConnection(type_, con)
            conn.type = type_;
            conn.conn_ = con; 
            if(conn.type == 1) 
                conn.conn_.Open();
            end;
            
        end;
        
        function curs = exec(conn, sql)
            if(conn.type == 0)
                curs = exec(conn.conn_, sql);
            else
                curs = conn.conn_.CreateCommand();
                curs.CommandText = sql;
                curs = curs.ExecuteReader();
            end;
        end;
        
        function close(conn)
            if(conn.type == 0)
                close(conn.conn_);
            else
                conn.conn_.Close();
            end;
        end
        
        function retcurs = fetch(conn, curs)
            if(conn.type == 0)
                retcurs = fetch(curs);
            else                
                i=1;
                fc = curs.FieldCount;
                A = cell(0);
                while(curs.Read())                    
                    for j = 1:fc
                        k = j-1;                          
                        A(i,j) = {char(curs.GetValue(k))};
                    end;
                    i=i+1;                    
                end;
                retcurs.Data = A;
            end;
        end;        
        
        function retcurs = fetchl(conn, curs, limit)
            if(conn.type == 0)
                retcurs = fetch(curs, limit);
            else                
                i=1;
                fc = curs.FieldCount;
                A = cell(0,fc);
                while(curs.Read())                         
                    for j = 1:fc
                        k = j-1;       
                        if(strcmp('Int',char(curs.GetDataTypeName(k))))
                             A(i,j) = {curs.GetValue(k)};                        
                        else
                             A(i,j) = {char(curs.GetValue(k).ToString())};
                        end;                       
                    end;
                    i=i+1;                    
                end;
                retcurs.Data = A;
            end;
        end;        
        
        
    end
end
