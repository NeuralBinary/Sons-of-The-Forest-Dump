using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x0200012D RID: 301
	[Token(Token = "0x200012D")]
	public class StimuliQueryVeryCloseDamagedBy : StimuliQueryTargetMonoBehaviour
	{
		// Token: 0x06000ADF RID: 2783 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ADF")]
		[Address(RVA = "0x2B90B20", Offset = "0x2B8F120", VA = "0x182B90B20")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AE0")]
		[Address(RVA = "0x2B90B50", Offset = "0x2B8F150", VA = "0x182B90B50")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AE1")]
		[Address(RVA = "0x2B90BD0", Offset = "0x2B8F1D0", VA = "0x182B90BD0", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000AE2 RID: 2786 RVA: 0x00006EE8 File Offset: 0x000050E8
		[Token(Token = "0x6000AE2")]
		[Address(RVA = "0x2B90C20", Offset = "0x2B8F220", VA = "0x182B90C20", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float distanceParam)
		{
			return default(bool);
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00006F00 File Offset: 0x00005100
		[Token(Token = "0x6000AE3")]
		[Address(RVA = "0x2B90AD0", Offset = "0x2B8F0D0", VA = "0x182B90AD0", Slot = "8")]
		protected override float GetDistance(VailActor actor, float distanceParam)
		{
			return 0f;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE4")]
		[Address(RVA = "0x2B8F080", Offset = "0x2B8D680", VA = "0x182B8F080")]
		protected StimuliQueryVeryCloseDamagedBy(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
