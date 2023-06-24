using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x0200012C RID: 300
	[Token(Token = "0x200012C")]
	public class StimuliQueryVeryClose : StimuliQueryTargetMonoBehaviour
	{
		// Token: 0x06000ADA RID: 2778 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ADA")]
		[Address(RVA = "0x2B90970", Offset = "0x2B8EF70", VA = "0x182B90970")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ADB")]
		[Address(RVA = "0x2B909A0", Offset = "0x2B8EFA0", VA = "0x182B909A0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ADC")]
		[Address(RVA = "0x2B90A80", Offset = "0x2B8F080", VA = "0x182B90A80", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x00006ED0 File Offset: 0x000050D0
		[Token(Token = "0x6000ADD")]
		[Address(RVA = "0x2B90AD0", Offset = "0x2B8F0D0", VA = "0x182B90AD0", Slot = "8")]
		protected override float GetDistance(VailActor actor, float distanceParam)
		{
			return 0f;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ADE")]
		[Address(RVA = "0x2B8F080", Offset = "0x2B8D680", VA = "0x182B8F080")]
		protected StimuliQueryVeryClose(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
