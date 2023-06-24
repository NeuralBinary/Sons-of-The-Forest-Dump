using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000120 RID: 288
	[Token(Token = "0x2000120")]
	public class StimuliQueryDistance : StimuliQueryTargetMonoBehaviour
	{
		// Token: 0x06000A9D RID: 2717 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A9D")]
		[Address(RVA = "0x2B8EED0", Offset = "0x2B8D4D0", VA = "0x182B8EED0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000A9E RID: 2718 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A9E")]
		[Address(RVA = "0x2B8EF00", Offset = "0x2B8D500", VA = "0x182B8EF00")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000A9F RID: 2719 RVA: 0x00006CF0 File Offset: 0x00004EF0
		[Token(Token = "0x6000A9F")]
		[Address(RVA = "0x2B8F020", Offset = "0x2B8D620", VA = "0x182B8F020", Slot = "8")]
		protected override float GetDistance(VailActor actor, float distanceParam)
		{
			return 0f;
		}

		// Token: 0x06000AA0 RID: 2720 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AA0")]
		[Address(RVA = "0x2B8F030", Offset = "0x2B8D630", VA = "0x182B8F030", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA1")]
		[Address(RVA = "0x2B8F080", Offset = "0x2B8D680", VA = "0x182B8F080")]
		protected StimuliQueryDistance(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
