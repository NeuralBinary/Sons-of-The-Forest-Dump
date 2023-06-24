using System;
using Il2CppDummyDll;
using Sons.Ai.Vail.StimuliTypes;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000123 RID: 291
	[Token(Token = "0x2000123")]
	public class StimuliQueryHasStatusEffect : StimuliQuery<StatusEffectStimuli>
	{
		// Token: 0x06000AAD RID: 2733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AAD")]
		[Address(RVA = "0x2B8F540", Offset = "0x2B8DB40", VA = "0x182B8F540")]
		public StimuliQueryHasStatusEffect(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}

		// Token: 0x06000AAE RID: 2734 RVA: 0x00006D50 File Offset: 0x00004F50
		[Token(Token = "0x6000AAE")]
		[Address(RVA = "0x2B8F5B0", Offset = "0x2B8DBB0", VA = "0x182B8F5B0", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000AAF RID: 2735 RVA: 0x00006D68 File Offset: 0x00004F68
		[Token(Token = "0x6000AAF")]
		[Address(RVA = "0x2B8F640", Offset = "0x2B8DC40", VA = "0x182B8F640")]
		public static bool IsValidType(Type stimuliType)
		{
			return default(bool);
		}

		// Token: 0x06000AB0 RID: 2736 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AB0")]
		[Address(RVA = "0x2B8F680", Offset = "0x2B8DC80", VA = "0x182B8F680")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AB1")]
		[Address(RVA = "0x2B8F6B0", Offset = "0x2B8DCB0", VA = "0x182B8F6B0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AB2")]
		[Address(RVA = "0x2B8F680", Offset = "0x2B8DC80", VA = "0x182B8F680", Slot = "7")]
		public override string GetName()
		{
			return null;
		}
	}
}
