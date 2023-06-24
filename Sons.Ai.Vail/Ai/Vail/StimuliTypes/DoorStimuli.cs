using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000196 RID: 406
	[Token(Token = "0x2000196")]
	[AddComponentMenu("Sons/Stimuli/Door Stimuli")]
	public class DoorStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000C8D RID: 3213 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C8D")]
		[Address(RVA = "0x2B9C760", Offset = "0x2B9AD60", VA = "0x182B9C760")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000C8E RID: 3214 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000C8E")]
		[Address(RVA = "0x2B9C790", Offset = "0x2B9AD90", VA = "0x182B9C790")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000C8F RID: 3215 RVA: 0x00007560 File Offset: 0x00005760
		[Token(Token = "0x6000C8F")]
		[Address(RVA = "0x9E1E00", Offset = "0x9E0400", VA = "0x1809E1E00")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000C90 RID: 3216 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C90")]
		[Address(RVA = "0x784C10", Offset = "0x783210", VA = "0x180784C10")]
		public void SetLocked(bool value)
		{
		}

		// Token: 0x06000C91 RID: 3217 RVA: 0x00007578 File Offset: 0x00005778
		[Token(Token = "0x6000C91")]
		[Address(RVA = "0x2B956A0", Offset = "0x2B93CA0", VA = "0x182B956A0", Slot = "11")]
		public override bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000C92 RID: 3218 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000C92")]
		[Address(RVA = "0x2B9C810", Offset = "0x2B9AE10", VA = "0x182B9C810")]
		private DoorStimuli()
		{
		}

		// Token: 0x04000866 RID: 2150
		[Token(Token = "0x4000866")]
		[FieldOffset(Offset = "0xA8")]
		private bool _isLocked;
	}
}
