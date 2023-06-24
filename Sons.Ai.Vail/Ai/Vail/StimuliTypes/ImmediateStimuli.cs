using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x0200015D RID: 349
	[Token(Token = "0x200015D")]
	public abstract class ImmediateStimuli : IStimuli
	{
		// Token: 0x06000B8E RID: 2958 RVA: 0x00007158 File Offset: 0x00005358
		[Token(Token = "0x6000B8E")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public virtual bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000B8F")]
		[Address(RVA = "0x2B94EA0", Offset = "0x2B934A0", VA = "0x182B94EA0", Slot = "8")]
		public virtual string GetLog()
		{
			return null;
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x00007170 File Offset: 0x00005370
		[Token(Token = "0x6000B90")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
		public virtual bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000B91")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected ImmediateStimuli()
		{
		}
	}
}
