using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x0200012E RID: 302
	[Token(Token = "0x200012E")]
	public class StimuliQueryWorld : StimuliQueryTargetMonoBehaviour
	{
		// Token: 0x06000AE5 RID: 2789 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AE5")]
		[Address(RVA = "0x2B90C90", Offset = "0x2B8F290", VA = "0x182B90C90")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AE6")]
		[Address(RVA = "0x2B90CC0", Offset = "0x2B8F2C0", VA = "0x182B90CC0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AE7")]
		[Address(RVA = "0x2B90DC0", Offset = "0x2B8F3C0", VA = "0x182B90DC0", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00006F18 File Offset: 0x00005118
		[Token(Token = "0x6000AE8")]
		[Address(RVA = "0x2B906C0", Offset = "0x2B8ECC0", VA = "0x182B906C0", Slot = "8")]
		protected override float GetDistance(VailActor actor, float distanceParam)
		{
			return 0f;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AE9")]
		[Address(RVA = "0x2B8F080", Offset = "0x2B8D680", VA = "0x182B8F080")]
		protected StimuliQueryWorld(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
