using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000158 RID: 344
	[Token(Token = "0x2000158")]
	public abstract class GroupStimuli : IStimuli
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B7A")]
		[Address(RVA = "0x2B94B30", Offset = "0x2B93130", VA = "0x182B94B30", Slot = "6")]
		public string GetLog()
		{
			return null;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x000070F8 File Offset: 0x000052F8
		[Token(Token = "0x6000B7B")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "4")]
		public bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x00007110 File Offset: 0x00005310
		[Token(Token = "0x6000B7C")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "5")]
		public bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B7D")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected GroupStimuli()
		{
		}
	}
}
