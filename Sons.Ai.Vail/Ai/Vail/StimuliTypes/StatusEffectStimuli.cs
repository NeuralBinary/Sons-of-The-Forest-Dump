using System;
using Il2CppDummyDll;
using Sons.Gameplay;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x02000206 RID: 518
	[Token(Token = "0x2000206")]
	public abstract class StatusEffectStimuli : IStimuli
	{
		// Token: 0x06000ED7 RID: 3799 RVA: 0x000083D0 File Offset: 0x000065D0
		[Token(Token = "0x6000ED7")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
		public virtual bool IsValid()
		{
			return default(bool);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000083E8 File Offset: 0x000065E8
		[Token(Token = "0x6000ED8")]
		[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
		public virtual bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000ED9 RID: 3801
		[Token(Token = "0x6000ED9")]
		public abstract string GetLog();

		// Token: 0x06000EDA RID: 3802 RVA: 0x00008400 File Offset: 0x00006600
		[Token(Token = "0x6000EDA")]
		[Address(RVA = "0x2BB0560", Offset = "0x2BAEB60", VA = "0x182BB0560")]
		public StatusEffectType GetStatusEffectType()
		{
			return StatusEffectType.Unknown;
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00008418 File Offset: 0x00006618
		[Token(Token = "0x6000EDB")]
		[Address(RVA = "0x2BB0580", Offset = "0x2BAEB80", VA = "0x182BB0580")]
		public static StatusEffectType GetStatusEffectType(Type stimuliType)
		{
			return StatusEffectType.Unknown;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EDC")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected StatusEffectStimuli()
		{
		}
	}
}
