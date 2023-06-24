using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000121 RID: 289
	[Token(Token = "0x2000121")]
	public class StimuliQueryFar : StimuliQueryTargetMonoBehaviour
	{
		// Token: 0x06000AA2 RID: 2722 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AA2")]
		[Address(RVA = "0x2B8F0F0", Offset = "0x2B8D6F0", VA = "0x182B8F0F0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000AA3 RID: 2723 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AA3")]
		[Address(RVA = "0x2B8F120", Offset = "0x2B8D720", VA = "0x182B8F120")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000AA4")]
		[Address(RVA = "0x2B8F240", Offset = "0x2B8D840", VA = "0x182B8F240", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000AA5 RID: 2725 RVA: 0x00006D08 File Offset: 0x00004F08
		[Token(Token = "0x6000AA5")]
		[Address(RVA = "0x2B8F290", Offset = "0x2B8D890", VA = "0x182B8F290", Slot = "8")]
		protected override float GetDistance(VailActor actor, float distanceParam)
		{
			return 0f;
		}

		// Token: 0x06000AA6 RID: 2726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AA6")]
		[Address(RVA = "0x2B8F080", Offset = "0x2B8D680", VA = "0x182B8F080")]
		protected StimuliQueryFar(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
