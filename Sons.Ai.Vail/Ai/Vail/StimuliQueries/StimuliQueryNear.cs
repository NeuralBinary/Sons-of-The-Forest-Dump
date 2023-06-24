using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000127 RID: 295
	[Token(Token = "0x2000127")]
	public class StimuliQueryNear : StimuliQueryTargetMonoBehaviour
	{
		// Token: 0x06000AC6 RID: 2758 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AC6")]
		[Address(RVA = "0x2B902D0", Offset = "0x2B8E8D0", VA = "0x182B902D0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AC7")]
		[Address(RVA = "0x2B90300", Offset = "0x2B8E900", VA = "0x182B90300")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x00006E28 File Offset: 0x00005028
		[Token(Token = "0x6000AC8")]
		[Address(RVA = "0x2B90420", Offset = "0x2B8EA20", VA = "0x182B90420", Slot = "8")]
		protected override float GetDistance(VailActor actor, float distanceParam)
		{
			return 0f;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AC9")]
		[Address(RVA = "0x2B90470", Offset = "0x2B8EA70", VA = "0x182B90470", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ACA")]
		[Address(RVA = "0x2B8F080", Offset = "0x2B8D680", VA = "0x182B8F080")]
		protected StimuliQueryNear(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
