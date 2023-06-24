using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000125 RID: 293
	[Token(Token = "0x2000125")]
	public class StimuliQueryLostSight : StimuliQuery<MonoBehaviourStimuli>
	{
		// Token: 0x06000AB9 RID: 2745 RVA: 0x00006DB0 File Offset: 0x00004FB0
		[Token(Token = "0x6000AB9")]
		[Address(RVA = "0x2B8F940", Offset = "0x2B8DF40", VA = "0x182B8F940", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00006DC8 File Offset: 0x00004FC8
		[Token(Token = "0x6000ABA")]
		[Address(RVA = "0x2B8F960", Offset = "0x2B8DF60", VA = "0x182B8F960")]
		private static bool FindLastSeen(VailActor actor, Type stimuliType, out IStimuli result)
		{
			return default(bool);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ABB")]
		[Address(RVA = "0x2B8FF30", Offset = "0x2B8E530", VA = "0x182B8FF30")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ABC")]
		[Address(RVA = "0x2B8FF60", Offset = "0x2B8E560", VA = "0x182B8FF60")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000ABD")]
		[Address(RVA = "0x2B90000", Offset = "0x2B8E600", VA = "0x182B90000", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x00006DE0 File Offset: 0x00004FE0
		[Token(Token = "0x6000ABE")]
		[Address(RVA = "0x2B90050", Offset = "0x2B8E650", VA = "0x182B90050")]
		public static bool IsValidType(Type stimuliType)
		{
			return default(bool);
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000ABF")]
		[Address(RVA = "0x2B8ECD0", Offset = "0x2B8D2D0", VA = "0x182B8ECD0")]
		protected StimuliQueryLostSight(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
