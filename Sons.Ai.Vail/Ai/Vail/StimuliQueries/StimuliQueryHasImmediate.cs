using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000122 RID: 290
	[Token(Token = "0x2000122")]
	public class StimuliQueryHasImmediate : StimuliQuery<ImmediateStimuli>
	{
		// Token: 0x06000AA7 RID: 2727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA7")]
		[Address(RVA = "0x2B8F2E0", Offset = "0x2B8D8E0", VA = "0x182B8F2E0")]
		public StimuliQueryHasImmediate(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}

		// Token: 0x06000AA8 RID: 2728 RVA: 0x00006D20 File Offset: 0x00004F20
		[Token(Token = "0x6000AA8")]
		[Address(RVA = "0x2B8F350", Offset = "0x2B8D950", VA = "0x182B8F350", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000AA9 RID: 2729 RVA: 0x00006D38 File Offset: 0x00004F38
		[Token(Token = "0x6000AA9")]
		[Address(RVA = "0x2B8F450", Offset = "0x2B8DA50", VA = "0x182B8F450")]
		public static bool IsValidType(Type stimuliType)
		{
			return default(bool);
		}

		// Token: 0x06000AAA RID: 2730 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AAA")]
		[Address(RVA = "0x2B8F490", Offset = "0x2B8DA90", VA = "0x182B8F490")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AAB")]
		[Address(RVA = "0x2B8F4C0", Offset = "0x2B8DAC0", VA = "0x182B8F4C0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AAC")]
		[Address(RVA = "0x2B8F490", Offset = "0x2B8DA90", VA = "0x182B8F490", Slot = "7")]
		public override string GetName()
		{
			return null;
		}
	}
}
