using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000126 RID: 294
	[Token(Token = "0x2000126")]
	public class StimuliQueryMissingStatusEffect : StimuliQuery<StatusEffectStimuli>
	{
		// Token: 0x06000AC0 RID: 2752 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AC0")]
		[Address(RVA = "0x2B900B0", Offset = "0x2B8E6B0", VA = "0x182B900B0")]
		public StimuliQueryMissingStatusEffect(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x00006DF8 File Offset: 0x00004FF8
		[Token(Token = "0x6000AC1")]
		[Address(RVA = "0x2B90120", Offset = "0x2B8E720", VA = "0x182B90120", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x00006E10 File Offset: 0x00005010
		[Token(Token = "0x6000AC2")]
		[Address(RVA = "0x2B901C0", Offset = "0x2B8E7C0", VA = "0x182B901C0")]
		public static bool IsValidType(Type stimuliType)
		{
			return default(bool);
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AC3")]
		[Address(RVA = "0x2B90200", Offset = "0x2B8E800", VA = "0x182B90200")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AC4")]
		[Address(RVA = "0x2B90230", Offset = "0x2B8E830", VA = "0x182B90230")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AC5")]
		[Address(RVA = "0x2B90200", Offset = "0x2B8E800", VA = "0x182B90200", Slot = "7")]
		public override string GetName()
		{
			return null;
		}
	}
}
