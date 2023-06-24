using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000128 RID: 296
	[Token(Token = "0x2000128")]
	public class StimuliQueryNotWithinFar : StimuliQueryTargetMonoBehaviour
	{
		// Token: 0x06000ACB RID: 2763 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ACB")]
		[Address(RVA = "0x2B904C0", Offset = "0x2B8EAC0", VA = "0x182B904C0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ACC")]
		[Address(RVA = "0x2B904F0", Offset = "0x2B8EAF0", VA = "0x182B904F0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ACD")]
		[Address(RVA = "0x2B90590", Offset = "0x2B8EB90", VA = "0x182B90590", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00006E40 File Offset: 0x00005040
		[Token(Token = "0x6000ACE")]
		[Address(RVA = "0x2B905E0", Offset = "0x2B8EBE0", VA = "0x182B905E0", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00006E58 File Offset: 0x00005058
		[Token(Token = "0x6000ACF")]
		[Address(RVA = "0x2B8F290", Offset = "0x2B8D890", VA = "0x182B8F290", Slot = "8")]
		protected override float GetDistance(VailActor actor, float distanceParam)
		{
			return 0f;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD0")]
		[Address(RVA = "0x2B8F080", Offset = "0x2B8D680", VA = "0x182B8F080")]
		protected StimuliQueryNotWithinFar(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
