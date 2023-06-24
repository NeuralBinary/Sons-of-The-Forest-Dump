using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x0200011F RID: 287
	[Token(Token = "0x200011F")]
	public class StimuliQueryDamageReceived : StimuliQuery<DamageReceivedStimuli>
	{
		// Token: 0x06000A97 RID: 2711 RVA: 0x00006CC0 File Offset: 0x00004EC0
		[Token(Token = "0x6000A97")]
		[Address(RVA = "0x2B8ED40", Offset = "0x2B8D340", VA = "0x182B8ED40", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000A98 RID: 2712 RVA: 0x00006CD8 File Offset: 0x00004ED8
		[Token(Token = "0x6000A98")]
		[Address(RVA = "0x2B8ED70", Offset = "0x2B8D370", VA = "0x182B8ED70")]
		public static bool IsValidType(Type stimuliType)
		{
			return default(bool);
		}

		// Token: 0x06000A99 RID: 2713 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A99")]
		[Address(RVA = "0x2B8EDB0", Offset = "0x2B8D3B0", VA = "0x182B8EDB0")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000A9A RID: 2714 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A9A")]
		[Address(RVA = "0x2B8EDE0", Offset = "0x2B8D3E0", VA = "0x182B8EDE0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A9B")]
		[Address(RVA = "0x2B8EDB0", Offset = "0x2B8D3B0", VA = "0x182B8EDB0", Slot = "7")]
		public override string GetName()
		{
			return null;
		}

		// Token: 0x06000A9C RID: 2716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A9C")]
		[Address(RVA = "0x2B8EE60", Offset = "0x2B8D460", VA = "0x182B8EE60")]
		protected StimuliQueryDamageReceived(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}
	}
}
