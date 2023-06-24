using System;
using Il2CppDummyDll;

namespace Sons.Ai.Vail.StimuliQueries
{
	// Token: 0x02000129 RID: 297
	[Token(Token = "0x2000129")]
	public abstract class StimuliQueryTargetMonoBehaviour : StimuliQuery<MonoBehaviourStimuli>
	{
		// Token: 0x06000AD1 RID: 2769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000AD1")]
		[Address(RVA = "0x2B8F080", Offset = "0x2B8D680", VA = "0x182B8F080")]
		protected StimuliQueryTargetMonoBehaviour(Type targetType, IStimuliSortAction.SortValueDelegate sortAction, IStimuli.FilterDelegate filterAction)
		{
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00006E70 File Offset: 0x00005070
		[Token(Token = "0x6000AD2")]
		[Address(RVA = "0x2B906C0", Offset = "0x2B8ECC0", VA = "0x182B906C0", Slot = "8")]
		protected virtual float GetDistance(VailActor actor, float maxDistance)
		{
			return 0f;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00006E88 File Offset: 0x00005088
		[Token(Token = "0x6000AD3")]
		[Address(RVA = "0x2B906D0", Offset = "0x2B8ECD0", VA = "0x182B906D0", Slot = "6")]
		public override bool Evaluate(VailActor actor, out IStimuli result, float maxDistance)
		{
			return default(bool);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00006EA0 File Offset: 0x000050A0
		[Token(Token = "0x6000AD4")]
		[Address(RVA = "0x2B907B0", Offset = "0x2B8EDB0", VA = "0x182B907B0")]
		public static bool IsValidType(Type stimuliType)
		{
			return default(bool);
		}
	}
}
