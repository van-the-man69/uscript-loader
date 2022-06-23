using System;
using _003CPrivateImplementationDetails_003E_007B4655B3D5_002DB2C8_002D44CC_002D822D_002D4BC455962FE1_007D;
using Rocket.API;

namespace Ster.uScriptLoader
{
	public class Config : IRocketPluginConfiguration, IDefaultable
	{
		public bool Enabled;

		public string AuthenticationKey;

		public static readonly Func<int, int> dVNjcmlwdA_003D_003DZ2V0X0Zsb3dDb250cm9sUGF0Y2hfU3VmZml4 = Z2V0X1F1ZXJ5U3RyaW5nZ2V0TWFpbk1vZHVsZQ_003D_003DVXBkYXRlUGx1Z2lu;

		public void LoadDefaults()
		{
			int num = 0;
			do
			{
				if (num == 1)
				{
					Enabled = true;
					num = 2;
				}
				if (num == 2)
				{
					AuthenticationKey = _317E3346_002D2EAC_002D401E_002D8C50_002DF135246F6C81.A();
					num = 3;
				}
				if (num == 0)
				{
					num = 1;
				}
			}
			while (num != 3);
		}

		public static int Z2V0X1F1ZXJ5U3RyaW5nZ2V0TWFpbk1vZHVsZQ_003D_003DVXBkYXRlUGx1Z2lu(int P_0)
		{
			//Discarded unreachable code: IL_0024
			int num = 0;
			int result = default(int);
			while (num != 2)
			{
				if (num == 1)
				{
					result = P_0;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
			}
			return result;
		}

		public static int T25Ib29rQWRkZWQ_003D(char P_0)
		{
			//Discarded unreachable code: IL_0024
			int num = 0;
			int result = default(int);
			while (num != 2)
			{
				if (num == 1)
				{
					result = P_0;
					num = 2;
				}
				if (num == 0)
				{
					num = 1;
				}
				if (num == 3)
				{
					break;
				}
			}
			return result;
		}
	}
}
