﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EfficientCareLookUp.Properties {
    
    
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "14.0.0.0")]
    internal sealed partial class Settings : global::System.Configuration.ApplicationSettingsBase {
        
        private static Settings defaultInstance = ((Settings)(global::System.Configuration.ApplicationSettingsBase.Synchronized(new Settings())));
        
        public static Settings Default {
            get {
                return defaultInstance;
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("vsbslgprd01.zmr.zimmer.com")]
        public string POSTGRES_HOST {
            get {
                return ((string)(this["POSTGRES_HOST"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("postgres")]
        public string POSTGRES_DATABASE {
            get {
                return ((string)(this["POSTGRES_DATABASE"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("5432")]
        public string POSTGRES_PORT {
            get {
                return ((string)(this["POSTGRES_PORT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("doarni")]
        public string POSTGRES_USERNAME {
            get {
                return ((string)(this["POSTGRES_USERNAME"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("ZimmerBiomet")]
        public string POSTGRES_PASSWORD {
            get {
                return ((string)(this["POSTGRES_PASSWORD"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("10.201.207.188")]
        public string ORACLE_HOST {
            get {
                return ((string)(this["ORACLE_HOST"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("smsprd")]
        public string ORACLE_SID {
            get {
                return ((string)(this["ORACLE_SID"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("1521")]
        public string ORACLE_PORT {
            get {
                return ((string)(this["ORACLE_PORT"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("logistics")]
        public string ORACLE_USERNAME {
            get {
                return ((string)(this["ORACLE_USERNAME"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("log78gist")]
        public string ORACLE_PASSWORD {
            get {
                return ((string)(this["ORACLE_PASSWORD"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("WITH S0 AS (\r\n    SELECT DISTINCT\r\n      P.ID AS PRODUCT_ID,\r\n      PC.COMPONENT_" +
            "PRODUCT_ID,\r\n      PC.QUANTITY\r\n    FROM\r\n      SMS_WRITE.PRODUCT P\r\n      LEFT " +
            "JOIN SMS_WRITE.PRODUCT_COMPONENT PC ON P.ID = PC.PRODUCT_ID\r\n    WHERE\r\n      P." +
            "PRODUCT_TYPE IN (1, 2)\r\n),\r\n    S1 AS (\r\n      SELECT\r\n        P.ID             " +
            "        AS KIT_PRODUCT_ID,\r\n        P.PRODUCT_NUMBER         AS KIT_PRODUCT_NUMB" +
            "ER,\r\n        P.EDI_NUMBER             AS KIT_EDI,\r\n        P.DESCRIPTION        " +
            "    AS KIT_DESCRIPTION,\r\n        P2.PRODUCT_NUMBER        AS COMPONENT_PRODUCT_N" +
            "UMBER,\r\n        P2.ID                    AS COMPONENT_PROD_ID,\r\n        P2.EDI_N" +
            "UMBER            AS COMPONENT_EDI_NUMBER,\r\n        P2.DESCRIPTION           AS C" +
            "OMPONENT_DESCRIPTION,\r\n        S0.QUANTITY              AS COMPONENT_QUANTITY_IN" +
            "_KIT,\r\n        COUNT(P2.PRODUCT_NUMBER) AS TOTAL_COMPONENT_QTY_IN_KIT\r\n      FRO" +
            "M\r\n        S0\r\n        LEFT JOIN SMS_WRITE.PRODUCT P ON S0.PRODUCT_ID = P.ID\r\n  " +
            "      LEFT JOIN SMS_WRITE.PRODUCT P2 ON S0.COMPONENT_PRODUCT_ID = P2.ID\r\n      G" +
            "ROUP BY\r\n        P.ID, P.PRODUCT_NUMBER, P.EDI_NUMBER, P.DESCRIPTION,\r\n        P" +
            "2.ID, P2.EDI_NUMBER, P2.PRODUCT_NUMBER, P2.DESCRIPTION,\r\n        S0.QUANTITY\r\n  " +
            "),\r\n\r\n    S5 AS (\r\n      SELECT\r\n        P2.PRODUCT_NUMBER                      " +
            "       AS KIT_PROD_NUMBER,\r\n        PS.SERIAL_NUMBER                            " +
            "  AS SERIAL_NUMBER,\r\n        B.ZONE || \'-\' || B.POSITION || \'-\' || B.SHELF AS KI" +
            "T_BIN,\r\n        P.EDI_NUMBER                                  AS COMPONENT_EDI,\r" +
            "\n        SUM(S.QUANTITY_AVAILABLE)                     AS QUANTITY_AVAILABLE,\r\n " +
            "       PL.LOT_NUMBER                                 AS COMPONENT_LOT_NUMBER\r\n  " +
            "    FROM\r\n        SMS_WRITE.STOCK S\r\n        LEFT JOIN SMS_WRITE.PRODUCT P ON S." +
            "PRODUCT_ID = P.ID\r\n        LEFT JOIN SMS_WRITE.STOCK S2 ON S.CONTAINER_ID = S2.I" +
            "D AND S.CONTAINER_TYPE = 2\r\n        LEFT JOIN SMS_WRITE.PRODUCT P2 ON S2.PRODUCT" +
            "_ID = P2.ID\r\n        LEFT JOIN SMS_WRITE.PRODUCT_SERIAL PS ON S2.SERIAL_ID = PS." +
            "ID\r\n        LEFT JOIN SMS_WRITE.BIN B ON S2.CONTAINER_ID = B.ID AND S2.CONTAINER" +
            "_TYPE = 1\r\n        LEFT JOIN SMS_WRITE.PRODUCT_LOT PL ON S.LOT_ID = PL.ID\r\n     " +
            " WHERE\r\n        S.LOCATION_TYPE = 1\r\n        AND S.LOCATION_ID IN (370, 1871)\r\n " +
            "       AND S.STOCK_TYPE = 2\r\n        AND S.CONTAINER_TYPE = 2\r\n        AND P2.PR" +
            "ODUCT_NUMBER IS NOT NULL\r\n      GROUP BY\r\n        PL.LOT_NUMBER,\r\n        P2.PRO" +
            "DUCT_NUMBER,\r\n        PS.SERIAL_NUMBER,\r\n        B.ZONE || \'-\' || B.POSITION || " +
            "\'-\' || B.SHELF,\r\n        P.EDI_NUMBER\r\n  ),\r\n    S7 AS (\r\n      SELECT DISTINCT\r" +
            "\n        S.LOCATION_ID,\r\n        P.PRODUCT_NUMBER                              A" +
            "S KIT_PRODUCT_NUMBER,\r\n        PS.ID                                         AS " +
            "SERIAL_ID,\r\n        PS.SERIAL_NUMBER,\r\n        S.HOLD_REASON,\r\n        S.HOLD_NO" +
            "TE,\r\n        B.ZONE || \'-\' || B.POSITION || \'-\' || B.SHELF AS KIT_BIN,\r\n        " +
            "S.ID                                          AS STOCK_ID,\r\n        S.CONTAINER_" +
            "ID                                AS BIN_ID\r\n      FROM\r\n        SMS_WRITE.STOCK" +
            " S\r\n        LEFT JOIN SMS_WRITE.PRODUCT P ON S.PRODUCT_ID = P.ID\r\n        LEFT J" +
            "OIN SMS_WRITE.PRODUCT_SERIAL PS ON PS.ID = S.SERIAL_ID\r\n        LEFT JOIN SMS_WR" +
            "ITE.BIN B ON B.ID = S.CONTAINER_ID AND S.CONTAINER_TYPE = 1\r\n      WHERE\r\n      " +
            "  S.INVENTORY_TYPE = 3\r\n        AND S.STOCK_TYPE IN (3, 4)\r\n        AND S.LOCATI" +
            "ON_TYPE = 1\r\n        AND S.LOCATION_ID IN (370, 1871)\r\n  ),\r\n    S8 AS (\r\n      " +
            "SELECT\r\n        P.PRODUCT_NUMBER,\r\n        P.ID                                 " +
            "         AS COMPONENT_ID,\r\n        SUM(S.QUANTITY_AVAILABLE)                    " +
            " AS QUANTITY_AVAILABLE,\r\n        B.ZONE || \'-\' || B.POSITION || \'-\' || B.SHELF A" +
            "S COMPONENT_BIN,\r\n        B.ID                                          AS COMPO" +
            "NENT_BIN_ID,\r\n        CASE\r\n        WHEN B.LOCATION_ID = 370\r\n          THEN \'SO" +
            "UTHAVEN\'\r\n        WHEN B.LOCATION_ID = 1871\r\n          THEN \'WARSAW\'\r\n        EN" +
            "D                                           AS WAREHOUSE_BIN\r\n      FROM\r\n      " +
            "  SMS_WRITE.STOCK S\r\n        LEFT JOIN SMS_WRITE.PRODUCT P ON S.PRODUCT_ID = P.I" +
            "D\r\n        LEFT JOIN SMS_WRITE.BIN B ON S.CONTAINER_ID = B.ID AND S.CONTAINER_TY" +
            "PE = 1\r\n      WHERE\r\n        S.LOCATION_ID IN (370, 1871)\r\n        AND S.STOCK_T" +
            "YPE IN (1, 2)\r\n        AND S.QUANTITY_AVAILABLE > 0\r\n        AND B.LOCATION_ID I" +
            "N (370, 1871)\r\n      GROUP BY\r\n        P.PRODUCT_NUMBER, P.ID, B.ZONE, B.POSITIO" +
            "N, B.SHELF, B.LOCATION_ID, B.ID\r\n  ),\r\n    S9 AS (\r\n      SELECT\r\n        S7.LOC" +
            "ATION_ID,\r\n        S1.KIT_PRODUCT_ID,\r\n        S1.KIT_PRODUCT_NUMBER,\r\n        S" +
            "1.KIT_EDI,\r\n        S1.KIT_DESCRIPTION,\r\n        S7.SERIAL_NUMBER,\r\n        S7.S" +
            "ERIAL_ID,\r\n        S7.KIT_BIN,\r\n        S7.STOCK_ID,\r\n        S7.BIN_ID,\r\n      " +
            "  S1.COMPONENT_PRODUCT_NUMBER,\r\n        S1.COMPONENT_PROD_ID,\r\n        S1.COMPON" +
            "ENT_EDI_NUMBER,\r\n        S1.COMPONENT_DESCRIPTION,\r\n        S1.COMPONENT_QUANTIT" +
            "Y_IN_KIT,\r\n        S1.TOTAL_COMPONENT_QTY_IN_KIT,\r\n        S7.HOLD_REASON,\r\n    " +
            "    S7.HOLD_NOTE\r\n      FROM\r\n        S1\r\n        LEFT JOIN S7 ON S1.KIT_PRODUCT" +
            "_NUMBER = S7.KIT_PRODUCT_NUMBER\r\n  ),\r\n    WRAPUP AS (\r\n      SELECT\r\n        S9" +
            ".KIT_PRODUCT_ID                                                                 " +
            "      AS KIT_PRODUCT_ID,\r\n        \'Z-\' || S9.KIT_PRODUCT_ID || \'-\' || S9.SERIAL_" +
            "NUMBER                                    AS KIT_BARCODE,\r\n        S9.KIT_PRODUC" +
            "T_NUMBER                                                                   AS KI" +
            "T_PRODUCT_NUMBER,\r\n        S9.KIT_EDI                                           " +
            "                                   AS KIT_EDI_NUMBER,\r\n        S9.KIT_DESCRIPTIO" +
            "N                                                                      AS KIT_DE" +
            "SCRIPTION,\r\n        S9.SERIAL_NUMBER                                            " +
            "                            AS KIT_SERIAL_NUMBER,\r\n        S9.SERIAL_ID         " +
            "                                                                   AS KIT_SERIAL" +
            "_ID,\r\n        S9.KIT_BIN,\r\n        S9.BIN_ID                                    " +
            "                                           AS KIT_BIN_ID,\r\n        CASE\r\n       " +
            " WHEN S9.LOCATION_ID = 370\r\n          THEN \'SOUTHAVEN\'\r\n        WHEN S9.LOCATION" +
            "_ID = 1871\r\n          THEN \'WARSAW\'\r\n        END                                " +
            "                                                     AS WAREHOUSE_LOCATION,\r\n   " +
            "     S9.COMPONENT_PRODUCT_NUMBER                                                " +
            "             AS COMPONENT_PRODUCT_NUMBER,\r\n        S9.COMPONENT_PROD_ID         " +
            "                                                           AS COMPONENT_PRODUCT_" +
            "ID,\r\n        S9.COMPONENT_DESCRIPTION                                           " +
            "                     AS COMPONENT_DESCRIPTION,\r\n        COALESCE(S8.QUANTITY_AVA" +
            "ILABLE,\r\n                 0)                                                    " +
            "                         AS COMPONENT_QTY_ON_SHELF,\r\n        COALESCE(S8.COMPONE" +
            "NT_BIN, NULL)                                                        AS COMPONEN" +
            "T_BIN,\r\n        COALESCE(S8.WAREHOUSE_BIN, \'NONE AVAILABLE\')                    " +
            "                        AS WAREHOUSE_BIN,\r\n        S8.COMPONENT_BIN_ID,\r\n       " +
            " S9.COMPONENT_QUANTITY_IN_KIT                                                   " +
            "         AS COMPONENT_QUANTITY_IN_KIT_STD,\r\n        COUNT(*)\r\n        OVER (\r\n  " +
            "        PARTITION BY S9.TOTAL_COMPONENT_QTY_IN_KIT, S9.SERIAL_NUMBER, S9.KIT_PRO" +
            "DUCT_NUMBER ) AS TOTAL_COMPONENTS_IN_KIT_STD,\r\n        COALESCE(S5.QUANTITY_AVAI" +
            "LABLE, 0)                                                      AS QTY_IN_KIT,\r\n " +
            "       SUM(S9.COMPONENT_QUANTITY_IN_KIT - COALESCE(S5.QUANTITY_AVAILABLE, 0))\r\n " +
            "       OVER (\r\n          PARTITION BY S9.KIT_PRODUCT_NUMBER, S9.SERIAL_NUMBER ) " +
            "                               AS PIECES_MISSING,\r\n        S9.HOLD_REASON,\r\n    " +
            "    S9.HOLD_NOTE,\r\n        S9.STOCK_ID                                          " +
            "                                   AS KIT_STOCK_ID,\r\n        S9.BIN_ID          " +
            "                                                                     AS KIT_CONT" +
            "AINER_ID\r\n      FROM\r\n        S9\r\n        LEFT JOIN S5 ON S9.KIT_PRODUCT_NUMBER " +
            "= S5.KIT_PROD_NUMBER AND S9.SERIAL_NUMBER = S5.SERIAL_NUMBER AND\r\n              " +
            "          S9.COMPONENT_EDI_NUMBER = S5.COMPONENT_EDI\r\n        LEFT JOIN S8 ON S8" +
            ".COMPONENT_ID = S9.COMPONENT_PROD_ID\r\n      WHERE\r\n        S9.KIT_PRODUCT_NUMBER" +
            " LIKE \'%{0}%\'\r\n      GROUP BY\r\n        S9.BIN_ID,\r\n        S8.COMPONENT_BIN_ID,\r" +
            "\n        S8.WAREHOUSE_BIN,\r\n        S9.LOCATION_ID,\r\n        S9.HOLD_REASON,\r\n  " +
            "      S9.HOLD_NOTE,\r\n        S9.KIT_PRODUCT_ID,\r\n        S9.SERIAL_NUMBER,\r\n    " +
            "    S9.SERIAL_ID,\r\n        S9.KIT_PRODUCT_NUMBER,\r\n        S9.KIT_DESCRIPTION,\r\n" +
            "        S9.KIT_EDI,\r\n        S9.KIT_BIN,\r\n        S9.COMPONENT_EDI_NUMBER,\r\n    " +
            "    S8.QUANTITY_AVAILABLE,\r\n        S8.COMPONENT_BIN,\r\n        S9.COMPONENT_QUAN" +
            "TITY_IN_KIT,\r\n        S9.TOTAL_COMPONENT_QTY_IN_KIT,\r\n        S9.COMPONENT_DESCR" +
            "IPTION,\r\n        S9.COMPONENT_PROD_ID,\r\n        S9.COMPONENT_PRODUCT_NUMBER,\r\n  " +
            "      S5.QUANTITY_AVAILABLE,\r\n        S9.STOCK_ID\r\n      ORDER BY\r\n        S9.SE" +
            "RIAL_NUMBER,\r\n        S9.COMPONENT_PRODUCT_NUMBER\r\n  ),\r\n    sf AS (\r\n      SELE" +
            "CT\r\n        KIT_PRODUCT_ID,\r\n        KIT_PRODUCT_NUMBER,\r\n        KIT_DESCRIPTIO" +
            "N,\r\n        KIT_SERIAL_NUMBER,\r\n        KIT_SERIAL_ID,\r\n        KIT_BIN,\r\n      " +
            "  KIT_BIN_ID,\r\n        WAREHOUSE_LOCATION,\r\n        KIT_STOCK_ID,\r\n        KIT_C" +
            "ONTAINER_ID,\r\n        COMPONENT_PRODUCT_ID,\r\n        COMPONENT_PRODUCT_NUMBER,\r\n" +
            "        COMPONENT_DESCRIPTION,\r\n        COMPONENT_QTY_ON_SHELF,\r\n        COMPONE" +
            "NT_BIN,\r\n        WAREHOUSE_BIN,\r\n        COMPONENT_BIN_ID,\r\n        COMPONENT_QU" +
            "ANTITY_IN_KIT_STD,\r\n        TOTAL_COMPONENTS_IN_KIT_STD,\r\n        TOTAL_COMPONEN" +
            "TS_IN_KIT_STD - PIECES_MISSING AS TOTAL_PIECES_IN_KIT,\r\n        QTY_IN_KIT      " +
            "                             AS COMPONENT_QTY_IN_KIT,\r\n        PIECES_MISSING,\r\n" +
            "        CASE\r\n        WHEN PIECES_MISSING = 0\r\n          THEN \'VALID\'\r\n        W" +
            "HEN PIECES_MISSING != 0\r\n          THEN \'INVALID\'\r\n        WHEN KIT_SERIAL_NUMBE" +
            "R IS NULL\r\n          THEN \'NOT_BUILT\'\r\n        END                              " +
            "            AS KIT_HEALTH,\r\n        HOLD_NOTE,\r\n        HOLD_REASON,\r\n        CA" +
            "SE\r\n        WHEN HOLD_REASON = 1\r\n          THEN \'CORPORATE_HOLD\'\r\n        WHEN " +
            "HOLD_REASON = 2\r\n          THEN \'AWAITING_QC_CHECK\'\r\n        WHEN HOLD_REASON = " +
            "3\r\n          THEN \'INVENTORY_STAGING\'\r\n        WHEN HOLD_REASON = 4\r\n          T" +
            "HEN \'MISSING_ITEMS\'\r\n        WHEN HOLD_REASON = 5\r\n          THEN \'PICK_SHORTAGE" +
            "\'\r\n        WHEN HOLD_REASON = 6\r\n          THEN \'CYCLE_COUNT_IN_PROGRESS\'\r\n     " +
            "   WHEN HOLD_REASON = 7\r\n          THEN \'NOT_FOUND_DURING_CYCLE_COUNT\'\r\n        " +
            "END                                          AS HOLD_REASON_DESCRIPTION\r\n      F" +
            "ROM\r\n        WRAPUP\r\n      GROUP BY\r\n        KIT_BIN_ID,\r\n        WAREHOUSE_BIN," +
            "\r\n        KIT_CONTAINER_ID,\r\n        KIT_STOCK_ID,\r\n        HOLD_NOTE,\r\n        " +
            "HOLD_REASON,\r\n        KIT_PRODUCT_ID,\r\n        KIT_PRODUCT_NUMBER,\r\n        KIT_" +
            "DESCRIPTION,\r\n        KIT_SERIAL_NUMBER,\r\n        KIT_SERIAL_ID,\r\n        KIT_BI" +
            "N,\r\n        COMPONENT_BIN,\r\n        COMPONENT_QTY_ON_SHELF,\r\n        COMPONENT_P" +
            "RODUCT_ID,\r\n        COMPONENT_PRODUCT_NUMBER,\r\n        COMPONENT_DESCRIPTION,\r\n " +
            "       COMPONENT_QUANTITY_IN_KIT_STD,\r\n        TOTAL_COMPONENTS_IN_KIT_STD,\r\n   " +
            "     QTY_IN_KIT,\r\n        PIECES_MISSING,\r\n        WAREHOUSE_LOCATION,\r\n        " +
            "COMPONENT_BIN_ID\r\n      ORDER BY\r\n        KIT_PRODUCT_NUMBER\r\n  )\r\nSELECT DISTIN" +
            "CT\r\n  COMPONENT_PRODUCT_NUMBER,\r\n  COMPONENT_QTY_ON_SHELF,\r\n  COMPONENT_BIN,\r\n  " +
            "WAREHOUSE_BIN\r\nFROM\r\n  sf\r\nWHERE\r\n  WAREHOUSE_BIN IN ({1})\r\nORDER BY \r\n  WAREHOU" +
            "SE_BIN")]
        public string EFFICIENT_CARE_QUERY {
            get {
                return ((string)(this["EFFICIENT_CARE_QUERY"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("SELECT kit_product_number FROM doarni.effcient_care_kit_numbers;")]
        public string EFFICIENT_CARE_KIT_NUMBERS_QUERY {
            get {
                return ((string)(this["EFFICIENT_CARE_KIT_NUMBERS_QUERY"]));
            }
        }
        
        [global::System.Configuration.ApplicationScopedSettingAttribute()]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [global::System.Configuration.DefaultSettingValueAttribute("False")]
        public bool LOAD_KITS_ON_START {
            get {
                return ((bool)(this["LOAD_KITS_ON_START"]));
            }
        }
    }
}
