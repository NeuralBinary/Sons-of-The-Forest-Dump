using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Ai.Vail.StimuliTypes
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	public abstract class ZoneStimuli : MonoBehaviourStimuli
	{
		// Token: 0x06000EAC RID: 3756 RVA: 0x00008370 File Offset: 0x00006570
		[Token(Token = "0x6000EAC")]
		[Address(RVA = "0xE51980", Offset = "0xE4FF80", VA = "0x180E51980")]
		public static int GridType()
		{
			return 0;
		}

		// Token: 0x06000EAD RID: 3757 RVA: 0x00008388 File Offset: 0x00006588
		[Token(Token = "0x6000EAD")]
		[Address(RVA = "0x2BAF460", Offset = "0x2BADA60", VA = "0x182BAF460", Slot = "17")]
		public override Vector3 GetRandomPointInZone(bool clampToNavMesh)
		{
			return default(Vector3);
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EAE")]
		[Address(RVA = "0x2BAF6B0", Offset = "0x2BADCB0", VA = "0x182BAF6B0")]
		private void CreateBoundsShape()
		{
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000083A0 File Offset: 0x000065A0
		[Token(Token = "0x6000EAF")]
		[Address(RVA = "0x2BAF8D0", Offset = "0x2BADED0", VA = "0x182BAF8D0")]
		public bool IsNearBounds(Vector3 position, float maxDistance, bool ignoreY)
		{
			return default(bool);
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000083B8 File Offset: 0x000065B8
		[Token(Token = "0x6000EB0")]
		[Address(RVA = "0x2BAFAA0", Offset = "0x2BAE0A0", VA = "0x182BAFAA0")]
		public float BoundsDistance(Vector3 position)
		{
			return 0f;
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB1")]
		[Address(RVA = "0x2BAFCF0", Offset = "0x2BAE2F0", VA = "0x182BAFCF0")]
		private void SnapToTerrain()
		{
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000EB2")]
		[Address(RVA = "0x1243280", Offset = "0x1241880", VA = "0x181243280")]
		protected ZoneStimuli()
		{
		}

		// Token: 0x040008FF RID: 2303
		[Token(Token = "0x40008FF")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected BoundsShape _zoneBounds;

		// Token: 0x04000900 RID: 2304
		[Token(Token = "0x4000900")]
		[FieldOffset(Offset = "0xB0")]
		private BoundsShape.SphereBounds _sphereBounds;

		// Token: 0x04000901 RID: 2305
		[Token(Token = "0x4000901")]
		[FieldOffset(Offset = "0xC8")]
		private bool _hasSphereBounds;
	}
}
