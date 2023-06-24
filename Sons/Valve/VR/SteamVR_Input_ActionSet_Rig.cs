using System;
using Il2CppDummyDll;

namespace Valve.VR
{
	// Token: 0x020002F8 RID: 760
	[Token(Token = "0x20002F8")]
	public class SteamVR_Input_ActionSet_Rig : SteamVR_ActionSet
	{
		// Token: 0x1700027B RID: 635
		// (get) Token: 0x060013EC RID: 5100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027B")]
		public virtual SteamVR_Action_Pose HandL
		{
			[Token(Token = "0x60013EC")]
			[Address(RVA = "0x31F9F40", Offset = "0x31F8540", VA = "0x1831F9F40", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x060013ED RID: 5101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027C")]
		public virtual SteamVR_Action_Pose HandR
		{
			[Token(Token = "0x60013ED")]
			[Address(RVA = "0x31F9FA0", Offset = "0x31F85A0", VA = "0x1831F9FA0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x060013EE RID: 5102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700027D")]
		public virtual SteamVR_Action_Vibration Haptic
		{
			[Token(Token = "0x60013EE")]
			[Address(RVA = "0x31FA000", Offset = "0x31F8600", VA = "0x1831FA000", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013EF")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		public SteamVR_Input_ActionSet_Rig()
		{
		}
	}
}
