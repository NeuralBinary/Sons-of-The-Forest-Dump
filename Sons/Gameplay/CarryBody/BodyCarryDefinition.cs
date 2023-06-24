using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.CarryBody
{
	// Token: 0x0200087F RID: 2175
	[Token(Token = "0x200087F")]
	public class BodyCarryDefinition : MonoBehaviour
	{
		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06003E1A RID: 15898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700081C")]
		public Transform AnimRootTransform
		{
			[Token(Token = "0x6003E1A")]
			[Address(RVA = "0x35CBFB0", Offset = "0x35CA5B0", VA = "0x1835CBFB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003E1B RID: 15899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1B")]
		[Address(RVA = "0x35CC010", Offset = "0x35CA610", VA = "0x1835CC010")]
		private void OnValidate()
		{
		}

		// Token: 0x06003E1C RID: 15900 RVA: 0x00013050 File Offset: 0x00011250
		[Token(Token = "0x6003E1C")]
		[Address(RVA = "0x35CC3A0", Offset = "0x35CA9A0", VA = "0x1835CC3A0")]
		public bool IsValidType(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06003E1D RID: 15901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1D")]
		[Address(RVA = "0x35CC400", Offset = "0x35CAA00", VA = "0x1835CC400")]
		public void SetupVariation(VailActorTypeId typeId, int actorSeed, int variationSubset, int dismemberMask, int bloodMask)
		{
		}

		// Token: 0x06003E1E RID: 15902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1E")]
		[Address(RVA = "0x35CC740", Offset = "0x35CAD40", VA = "0x1835CC740")]
		public void SetSyncAnimator(Animator srcAnimator)
		{
		}

		// Token: 0x06003E1F RID: 15903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003E1F")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public BodyCarryDefinition()
		{
		}

		// Token: 0x04003441 RID: 13377
		[Token(Token = "0x4003441")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04003442 RID: 13378
		[Token(Token = "0x4003442")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DismembermentController _dismembermentController;

		// Token: 0x04003443 RID: 13379
		[Token(Token = "0x4003443")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterBloodRevealProxy _bloodReveal;

		// Token: 0x04003444 RID: 13380
		[Token(Token = "0x4003444")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RendererSection _bodyRenderer;

		// Token: 0x04003445 RID: 13381
		[Token(Token = "0x4003445")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RendererSection _headRenderer;

		// Token: 0x04003446 RID: 13382
		[Token(Token = "0x4003446")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("_materialsByType")]
		private BodyCarryDefinition.ObjectsByType[] _objectsByType;

		// Token: 0x02000880 RID: 2176
		[Token(Token = "0x2000880")]
		[Serializable]
		private class ObjectsByType
		{
			// Token: 0x06003E20 RID: 15904 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E20")]
			[Address(RVA = "0x35CC830", Offset = "0x35CAE30", VA = "0x1835CC830")]
			public void PreApply()
			{
			}

			// Token: 0x06003E21 RID: 15905 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E21")]
			[Address(RVA = "0x35CCA20", Offset = "0x35CB020", VA = "0x1835CCA20")]
			public void Apply()
			{
			}

			// Token: 0x06003E22 RID: 15906 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003E22")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public ObjectsByType()
			{
			}

			// Token: 0x04003447 RID: 13383
			[Token(Token = "0x4003447")]
			[FieldOffset(Offset = "0x10")]
			public VailActorTypeId _typeId;

			// Token: 0x04003448 RID: 13384
			[Token(Token = "0x4003448")]
			[FieldOffset(Offset = "0x18")]
			public GameObject[] _hideObjects;

			// Token: 0x04003449 RID: 13385
			[Token(Token = "0x4003449")]
			[FieldOffset(Offset = "0x20")]
			public GameObject[] _showObjects;
		}
	}
}
