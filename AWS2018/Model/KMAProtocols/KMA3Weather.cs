using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CommManager.Datas.KMAProtocols
{
    [StructLayout(LayoutKind.Sequential, Pack = 1, CharSet = CharSet.Ansi)]
    class KMA3Weather
    {
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Header;				// 	0xFF, 0xFF

        public byte ProtocolVersionYear;
        public byte ProtocolVersionMonth;
        public byte ProtocolVersionDay;

        public byte Year;			  // 년	1	현재/과거 년 (1980 ~ 2079)
        public byte Month;			  // 월	1	현재/과거 월 (   1 ~   12)
        public byte Day;			  // 일	1	현재/과거 일 (   1 ~   31)
        public byte Hour;			  // 시	1	현재/과거 시 (   0 ~   23)
        public byte Minute;			  // 분	1	현재/과거 분 (   0 ~   59)

        public byte DataDivision;	  // M : 순간 자료,  O : 최근 1 분,  A : 과거자료, X : 해당날짜의 자료가 없음을 알림.
        public byte DataNo;

        public ushort LoggerID;		  // LOGGER ID NUMBER (0 ~ 32767 BINARY)

        public ushort Sensor_0_Datas; //1분 평균 기온    
        public ushort Sensor_1_Datas; //1분 평균 풍향      
        public ushort Sensor_2_Datas; //1분 평균 풍속     
        public ushort Sensor_3_Datas; //1분 돌풍 풍향       
        public ushort Sensor_4_Datas; //1분 돌풍 풍속       
        public ushort Sensor_5_Datas; //00시부터 현재까지 누적강수량       
        public ushort Sensor_6_Datas; //1분 평균 현지기압       
        public ushort Sensor_7_Datas; //1분 강수유무
        public ushort Sensor_8_Datas; //10분 누적적설
        public ushort Sensor_9_Datas; //1분 평균 상대습도
        public ushort Sensor_10_Datas; //00시부터 현재까지 누적강수량

        public ushort Sensor_11_Datas;
        public ushort Sensor_12_Datas;
        public ushort Sensor_13_Datas;
        public ushort Sensor_14_Datas;
        public ushort Sensor_15_Datas;
        public ushort Sensor_16_Datas;
        public ushort Sensor_17_Datas;
        public ushort Sensor_18_Datas;
        public ushort Sensor_19_Datas;
        public ushort Sensor_20_Datas;
        public ushort Sensor_21_Datas;
        public ushort Sensor_22_Datas;
        public ushort Sensor_23_Datas;

        public ushort Sensor_24_Datas;
        public ushort Sensor_25_Datas;
        public ushort Sensor_26_Datas;
        public ushort Sensor_27_Datas;
        public ushort Sensor_28_Datas;
        public ushort Sensor_29_Datas;
        public ushort Sensor_30_Datas;
        public ushort Sensor_31_Datas;
        public ushort Sensor_32_Datas;
        public ushort Sensor_33_Datas;
        public ushort Sensor_34_Datas;


        public ushort Sensor_35_Datas;
        public ushort Sensor_36_Datas;
        public ushort Sensor_37_Datas;
        public ushort Sensor_38_Datas;
        public ushort Sensor_39_Datas;
        public ushort Sensor_40_Datas;
        public ushort Sensor_41_Datas;
        public ushort Sensor_42_Datas;
        public ushort Sensor_43_Datas;
        public ushort Sensor_44_Datas;
        public ushort Sensor_45_Datas;
        public ushort Sensor_46_Datas;
        public ushort Sensor_47_Datas;

        public ushort Sensor_48_Datas;
        public ushort Sensor_49_Datas;
        public ushort Sensor_50_Datas;
        public ushort Sensor_51_Datas;
        public ushort Sensor_52_Datas;
        public ushort Sensor_53_Datas;
        public ushort Sensor_54_Datas;
        public ushort Sensor_55_Datas;
        public ushort Sensor_56_Datas;
        public ushort Sensor_57_Datas;
        public ushort Sensor_58_Datas;
        public ushort Sensor_59_Datas;
        public ushort Sensor_60_Datas;
        public ushort Sensor_61_Datas;

        public ushort spare;
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 8)]
        public byte[] SensorStatus1;
        public byte Voltage;

        public byte Xor;				// 2 - 11항에 대한 XOR 
        public byte Add;				// 2 - 11항에 대한 ADD    
        [MarshalAs(UnmanagedType.ByValArray, SizeConst = 2)]
        public byte[] Tail;				// 0xFF, 0xFE


        /// <summary>
        /// 생성자
        /// </summary>
        public KMA3Weather()
        {
            this.Header = new byte[2] { 0xCC, 0xCC };
            ProtocolVersionYear = 0xCC;
            ProtocolVersionMonth = 0xCC;
            ProtocolVersionDay = 0xCC;

            Year = 0xCC;			  // 년	1	현재/과거 년 (1980 ~ 2079)
            Month = 0xCC;			  // 월	1	현재/과거 월 (   1 ~   12)
            Day = 0xCC;			  // 일	1	현재/과거 일 (   1 ~   31)
            Hour = 0xCC;			  // 시	1	현재/과거 시 (   0 ~   23)
            Minute = 0xCC;			  // 분	1	현재/과거 분 (   0 ~   59)

            DataDivision = 0xCC;	  // I : 순간 자료,  B : 1분.
            DataNo = 0xCC; //0,1,2 : 미사용, 3 : 일반용, 4 : 농관용, c

            LoggerID = new ushort();		  // LOGGER ID NUMBER (0 ~ 32767 BINARY)

            Sensor_0_Datas = new ushort(); //1분 평균 기온               
            Sensor_1_Datas = new ushort(); //1분 평균 풍향      
            Sensor_2_Datas = new ushort(); //1분 평균 풍속     
            Sensor_3_Datas = new ushort(); //1분 돌풍 풍향       
            Sensor_4_Datas = new ushort(); //1분 돌풍 풍속       
            Sensor_5_Datas = new ushort(); //00시부터 현재까지 누적강수량       
            Sensor_6_Datas = new ushort(); //1분 평균 현지기압       
            Sensor_7_Datas = new ushort(); //1분 강수유무
            Sensor_8_Datas = new ushort(); //적설
            Sensor_9_Datas = new ushort(); //상대습도
            Sensor_10_Datas = new ushort(); //00시부터 현재까지 누적강수량

            Sensor_11_Datas = new ushort(); //1분 평균 기온               
            Sensor_12_Datas = new ushort(); //1분 평균 풍향      
            Sensor_13_Datas = new ushort(); //1분 평균 풍속     
            Sensor_14_Datas = new ushort(); //1분 돌풍 풍향       
            Sensor_15_Datas = new ushort(); //1분 돌풍 풍속       
            Sensor_16_Datas = new ushort(); //00시부터 현재까지 누적강수량       
            Sensor_17_Datas = new ushort(); //1분 평균 현지기압       
            Sensor_18_Datas = new ushort(); //1분 강수유무
            Sensor_19_Datas = new ushort(); //적설
            Sensor_20_Datas = new ushort(); //상대습도
            Sensor_21_Datas = new ushort(); //00시부터 현재까지 누적강수량

            Sensor_22_Datas = new ushort(); //1분 평균 기온               
            Sensor_23_Datas = new ushort(); //1분 평균 풍향      
            Sensor_24_Datas = new ushort(); //1분 평균 풍속     
            Sensor_25_Datas = new ushort(); //1분 돌풍 풍향       
            Sensor_26_Datas = new ushort(); //1분 돌풍 풍속       
            Sensor_27_Datas = new ushort(); //00시부터 현재까지 누적강수량       
            Sensor_28_Datas = new ushort(); //1분 평균 현지기압       
            Sensor_29_Datas = new ushort(); //1분 강수유무
            Sensor_30_Datas = new ushort(); //적설
            Sensor_31_Datas = new ushort(); //상대습도
            Sensor_32_Datas = new ushort(); //00시부터 현재까지 누적강수량

            Sensor_33_Datas = new ushort(); //1분 평균 기온               
            Sensor_34_Datas = new ushort(); //1분 평균 풍향      
            Sensor_35_Datas = new ushort(); //1분 평균 풍속     
            Sensor_36_Datas = new ushort(); //1분 돌풍 풍향       
            Sensor_37_Datas = new ushort(); //1분 돌풍 풍속       
            Sensor_38_Datas = new ushort(); //00시부터 현재까지 누적강수량       
            Sensor_39_Datas = new ushort(); //1분 평균 현지기압       
            Sensor_40_Datas = new ushort(); //1분 강수유무
            Sensor_41_Datas = new ushort(); //적설
            Sensor_42_Datas = new ushort(); //상대습도
            Sensor_43_Datas = new ushort(); //00시부터 현재까지 누적강수량

            Sensor_44_Datas = new ushort(); //1분 강수유무
            Sensor_45_Datas = new ushort(); //적설
            Sensor_46_Datas = new ushort(); //상대습도
            Sensor_47_Datas = new ushort(); //00시부터 현재까지 누적강수량   

            Sensor_48_Datas = new ushort(); //1분 강수유무
            Sensor_49_Datas = new ushort(); //적설
            Sensor_50_Datas = new ushort(); //상대습도
            Sensor_51_Datas = new ushort(); //00시부터 현재까지 누적강수량   
            Sensor_52_Datas = new ushort(); //1분 강수유무
            Sensor_53_Datas = new ushort(); //적설
            Sensor_54_Datas = new ushort(); //상대습도            Sensor_47_Datas = new ushort(); //00시부터 현재까지 누적강수량   

            Sensor_55_Datas = new ushort(); //1분 강수유무
            Sensor_56_Datas = new ushort(); //적설
            Sensor_57_Datas = new ushort(); //상대습도
            Sensor_58_Datas = new ushort(); //00시부터 현재까지 누적강수량   
            Sensor_59_Datas = new ushort(); //적설
            Sensor_60_Datas = new ushort(); //상대습도
            Sensor_61_Datas = new ushort(); //00시부터 현재까지 누적강수량 



            Sensor_0_Datas = 0;
            Sensor_1_Datas = 0;
            Sensor_2_Datas = 0;
            Sensor_3_Datas = 0;
            Sensor_4_Datas = 0;
            Sensor_5_Datas = 0;
            Sensor_6_Datas = 0;
            Sensor_7_Datas = 0;
            Sensor_8_Datas = 0;
            Sensor_9_Datas = 0;
            Sensor_10_Datas = 0;

            Sensor_11_Datas = 0;
            Sensor_12_Datas = 0;
            Sensor_13_Datas = 0;
            Sensor_14_Datas = 0;
            Sensor_15_Datas = 0;
            Sensor_16_Datas = 0;
            Sensor_17_Datas = 0;
            Sensor_18_Datas = 0;
            Sensor_19_Datas = 0;
            Sensor_20_Datas = 0;
            Sensor_21_Datas = 0;

            Sensor_22_Datas = 0;
            Sensor_23_Datas = 0;
            Sensor_24_Datas = 0;
            Sensor_25_Datas = 0;
            Sensor_26_Datas = 0;
            Sensor_27_Datas = 0;
            Sensor_28_Datas = 0;
            Sensor_29_Datas = 0;
            Sensor_30_Datas = 0;
            Sensor_31_Datas = 0;
            Sensor_32_Datas = 0;

            Sensor_33_Datas = 0;
            Sensor_34_Datas = 0;
            Sensor_35_Datas = 0;
            Sensor_36_Datas = 0;
            Sensor_37_Datas = 0;
            Sensor_38_Datas = 0;
            Sensor_39_Datas = 0;
            Sensor_40_Datas = 0;
            Sensor_41_Datas = 0;
            Sensor_42_Datas = 0;
            Sensor_43_Datas = 0;

            Sensor_44_Datas = 0;
            Sensor_45_Datas = 0;
            Sensor_46_Datas = 0;
            Sensor_47_Datas = 0;

            Sensor_48_Datas = 0;
            Sensor_49_Datas = 0;
            Sensor_50_Datas = 0;
            Sensor_51_Datas = 0;
            Sensor_52_Datas = 0;
            Sensor_53_Datas = 0;
            Sensor_54_Datas = 0;

            Sensor_55_Datas = 0;
            Sensor_56_Datas = 0;
            Sensor_57_Datas = 0;
            Sensor_58_Datas = 0;
            Sensor_59_Datas = 0;
            Sensor_60_Datas = 0;
            Sensor_61_Datas = 0;


            spare = new ushort();
            Voltage = 0xCC;
            SensorStatus1 = new byte[8] { 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC, 0xCC };

            Xor = 0xCC;				// 2 - 11항에 대한 XOR 
            Add = 0xCC;				// 2 - 11항에 대한 ADD    

            this.Tail = new byte[2] { 0xCC, 0xCC };
        }

        public byte[] GetByte()
        {
            byte[] Data = new byte[Marshal.SizeOf(this)];
            IntPtr ptrStruct = IntPtr.Zero;
            try
            {
                ptrStruct = Marshal.AllocHGlobal(Marshal.SizeOf(this));
                Marshal.StructureToPtr(this, ptrStruct, true);
                System.Runtime.InteropServices.Marshal.Copy(ptrStruct, Data, 0, Marshal.SizeOf(this));
            }
            catch (Exception E)
            {
                Debug.WriteLine(E.Message);
            }
            finally
            {
                if (ptrStruct != IntPtr.Zero)
                    System.Runtime.InteropServices.Marshal.FreeHGlobal(ptrStruct);
            }
            return Data;
        }

        public static KMA3Weather SetByte(byte[] Buffer)
        {
            if (Marshal.SizeOf(typeof(KMA3Weather)) != Buffer.Length) throw new Exception("버퍼의 사이즈가 맞지 않습니다.");
            IntPtr ptrStruct = IntPtr.Zero;
            try
            {
                ptrStruct = Marshal.AllocHGlobal(System.Runtime.InteropServices.Marshal.SizeOf(typeof(KMA3Weather)));
                System.Runtime.InteropServices.Marshal.Copy(Buffer, 0, ptrStruct, Buffer.Length);
                return (KMA3Weather)Marshal.PtrToStructure(ptrStruct, typeof(KMA3Weather));
            }
            catch (Exception E)
            {
                Debug.WriteLine(E.Message);
                return null;
            }
            finally
            {
                if (ptrStruct != IntPtr.Zero)
                    System.Runtime.InteropServices.Marshal.FreeHGlobal(ptrStruct);
            }
        }
    }
}
