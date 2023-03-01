using System;
using Il2CppDummyDll;

namespace Valve.VR
{
	// Token: 0x02000306 RID: 774
	[Token(Token = "0x2000306")]
	public class SteamVR_Input_ActionSet_Rig : SteamVR_ActionSet
	{
		// Token: 0x17000273 RID: 627
		// (get) Token: 0x060013C1 RID: 5057 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000273")]
		public virtual SteamVR_Action_Pose HandL
		{
			[Token(Token = "0x60013C1")]
			[Address(RVA = "0x2C76B20", Offset = "0x2C75B20", VA = "0x182C76B20", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x060013C2 RID: 5058 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000274")]
		public virtual SteamVR_Action_Pose HandR
		{
			[Token(Token = "0x60013C2")]
			[Address(RVA = "0x2C76B80", Offset = "0x2C75B80", VA = "0x182C76B80", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x060013C3 RID: 5059 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000275")]
		public virtual SteamVR_Action_Vibration Haptic
		{
			[Token(Token = "0x60013C3")]
			[Address(RVA = "0x2C76BE0", Offset = "0x2C75BE0", VA = "0x182C76BE0", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x060013C4 RID: 5060 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60013C4")]
		[Address(RVA = "0x54C690", Offset = "0x54B690", VA = "0x18054C690")]
		public SteamVR_Input_ActionSet_Rig()
		{
		}
	}
}
