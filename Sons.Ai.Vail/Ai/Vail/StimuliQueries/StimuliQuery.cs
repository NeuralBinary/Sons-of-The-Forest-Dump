using System;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x0200011D RID: 285
	[Token(Token = "0x200011D")]
	public abstract class StimuliQuery<T> : IStimuliQuery where T : IStimuli
	{
		// Token: 0x06000A8B RID: 2699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8B")]
		protected StimuliQuery(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterDelegate)
		{
		}

		// Token: 0x06000A8C RID: 2700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8C")]
		private void SetStimuliFilterAction(IStimuli.FilterDelegate filterDelegate)
		{
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8D")]
		private void SetStimuliSortAction(IStimuliSortAction.SortValueDelegate sortAction)
		{
		}

		// Token: 0x06000A8E RID: 2702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000A8E")]
		private void SetStimuliType(Type targetType)
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A8F")]
		internal string GetStimuliTypeName(string prefix)
		{
			return null;
		}

		// Token: 0x06000A90 RID: 2704
		[Token(Token = "0x6000A90")]
		public abstract bool Evaluate(VailActor actor, out IStimuli result, float maxDistance);

		// Token: 0x06000A91 RID: 2705
		[Token(Token = "0x6000A91")]
		public abstract string GetName();

		// Token: 0x06000A92 RID: 2706 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000A92")]
		internal static IStimuli GetFirst(VailActor actor, Type stimuliType, IStimuliSortAction.SortValueDelegate sortValueDelegate, float maxDistance = -1f, [Optional] IStimuli.FilterDelegate filterDelegate)
		{
			return null;
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x00006CA8 File Offset: 0x00004EA8
		[Token(Token = "0x6000A93")]
		protected static bool MatchesType<TMatch>(Type stimuliType)
		{
			return default(bool);
		}

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		[SerializeReference]
		protected Type _stimuliType;

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected IStimuliSortAction.SortValueDelegate _sortAction;

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[Il2CppDummyDll.FieldOffset(Offset = "0x0")]
		protected IStimuli.FilterDelegate _filterAction;
	}
}
