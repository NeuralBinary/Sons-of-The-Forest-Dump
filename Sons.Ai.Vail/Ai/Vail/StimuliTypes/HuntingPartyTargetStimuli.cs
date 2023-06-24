using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001BA RID: 442
	[Token(Token = "0x20001BA")]
	[AddComponentMenu("Sons/Stimuli/HuntingPartyTargetStimuli")]
	public class HuntingPartyTargetStimuli : SearchPartyStimuli
	{
		// Token: 0x06000D39 RID: 3385 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D39")]
		[Address(RVA = "0x2BA2190", Offset = "0x2BA0790", VA = "0x182BA2190")]
		public static string GetMenuId()
		{
			return null;
		}

		// Token: 0x06000D3A RID: 3386 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D3A")]
		[Address(RVA = "0x2BA21C0", Offset = "0x2BA07C0", VA = "0x182BA21C0")]
		public static string[] GetMenuIds()
		{
			return null;
		}

		// Token: 0x06000D3B RID: 3387 RVA: 0x000079F8 File Offset: 0x00005BF8
		[Token(Token = "0x6000D3B")]
		[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000D3C RID: 3388 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000D3C")]
		[Address(RVA = "0x2BA2190", Offset = "0x2BA0790", VA = "0x182BA2190", Slot = "26")]
		public override string GetDebugName()
		{
			return null;
		}

		// Token: 0x06000D3D RID: 3389 RVA: 0x00007A10 File Offset: 0x00005C10
		[Token(Token = "0x6000D3D")]
		[Address(RVA = "0x2BA2240", Offset = "0x2BA0840", VA = "0x182BA2240")]
		private bool IsValidType(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06000D3E RID: 3390 RVA: 0x00007A28 File Offset: 0x00005C28
		[Token(Token = "0x6000D3E")]
		[Address(RVA = "0x2BA2260", Offset = "0x2BA0860", VA = "0x182BA2260", Slot = "12")]
		public override bool Validate(VailActor vailActor)
		{
			return default(bool);
		}

		// Token: 0x06000D3F RID: 3391 RVA: 0x00007A40 File Offset: 0x00005C40
		[Token(Token = "0x6000D3F")]
		[Address(RVA = "0x2BA2320", Offset = "0x2BA0920", VA = "0x182BA2320", Slot = "13")]
		public override bool Validate(WorldSimActor worldActor)
		{
			return default(bool);
		}

		// Token: 0x06000D40 RID: 3392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D40")]
		[Address(RVA = "0x2BA23F0", Offset = "0x2BA09F0", VA = "0x182BA23F0", Slot = "14")]
		public override void OnActorReachedStimuli(WorldSimActor worldActor, VailActor actor)
		{
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000D41")]
		[Address(RVA = "0x2BA2470", Offset = "0x2BA0A70", VA = "0x182BA2470")]
		public HuntingPartyTargetStimuli()
		{
		}

		// Token: 0x040008A4 RID: 2212
		[Token(Token = "0x40008A4")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		private float _maxActors;
	}
}
