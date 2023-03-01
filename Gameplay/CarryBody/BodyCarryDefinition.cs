using System;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Weapon;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Gameplay.CarryBody
{
	// Token: 0x02000723 RID: 1827
	[Token(Token = "0x2000723")]
	public class BodyCarryDefinition : MonoBehaviour
	{
		// Token: 0x17000603 RID: 1539
		// (get) Token: 0x06002FB0 RID: 12208 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000603")]
		public Transform AnimRootTransform
		{
			[Token(Token = "0x6002FB0")]
			[Address(RVA = "0x2E21DD0", Offset = "0x2E20DD0", VA = "0x182E21DD0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FB1 RID: 12209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB1")]
		[Address(RVA = "0x2E21890", Offset = "0x2E20890", VA = "0x182E21890")]
		private void OnValidate()
		{
		}

		// Token: 0x06002FB2 RID: 12210 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[Token(Token = "0x6002FB2")]
		[Address(RVA = "0x2E21830", Offset = "0x2E20830", VA = "0x182E21830")]
		public bool IsValidType(VailActorTypeId typeId)
		{
			return default(bool);
		}

		// Token: 0x06002FB3 RID: 12211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB3")]
		[Address(RVA = "0x2E21A90", Offset = "0x2E20A90", VA = "0x182E21A90")]
		public void SetupVariation(VailActorTypeId typeId, int actorSeed, int variationSubset, int dismemberMask, int bloodMask)
		{
		}

		// Token: 0x06002FB4 RID: 12212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB4")]
		[Address(RVA = "0x2E219F0", Offset = "0x2E209F0", VA = "0x182E219F0")]
		public void SetSyncAnimator(Animator srcAnimator)
		{
		}

		// Token: 0x06002FB5 RID: 12213 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002FB5")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public BodyCarryDefinition()
		{
		}

		// Token: 0x04002A16 RID: 10774
		[Token(Token = "0x4002A16")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04002A17 RID: 10775
		[Token(Token = "0x4002A17")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private DismembermentController _dismembermentController;

		// Token: 0x04002A18 RID: 10776
		[Token(Token = "0x4002A18")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private CharacterBloodRevealProxy _bloodReveal;

		// Token: 0x04002A19 RID: 10777
		[Token(Token = "0x4002A19")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private RendererSection _bodyRenderer;

		// Token: 0x04002A1A RID: 10778
		[Token(Token = "0x4002A1A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private RendererSection _headRenderer;

		// Token: 0x04002A1B RID: 10779
		[Token(Token = "0x4002A1B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[FormerlySerializedAs("_materialsByType")]
		private BodyCarryDefinition.ObjectsByType[] _objectsByType;

		// Token: 0x02000724 RID: 1828
		[Token(Token = "0x2000724")]
		[Serializable]
		private class ObjectsByType
		{
			// Token: 0x06002FB6 RID: 12214 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002FB6")]
			[Address(RVA = "0x2E368A0", Offset = "0x2E358A0", VA = "0x182E368A0")]
			public void PreApply()
			{
			}

			// Token: 0x06002FB7 RID: 12215 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002FB7")]
			[Address(RVA = "0x2E36770", Offset = "0x2E35770", VA = "0x182E36770")]
			public void Apply()
			{
			}

			// Token: 0x06002FB8 RID: 12216 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002FB8")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public ObjectsByType()
			{
			}

			// Token: 0x04002A1C RID: 10780
			[Token(Token = "0x4002A1C")]
			[FieldOffset(Offset = "0x10")]
			public VailActorTypeId _typeId;

			// Token: 0x04002A1D RID: 10781
			[Token(Token = "0x4002A1D")]
			[FieldOffset(Offset = "0x18")]
			public GameObject[] _hideObjects;

			// Token: 0x04002A1E RID: 10782
			[Token(Token = "0x4002A1E")]
			[FieldOffset(Offset = "0x20")]
			public GameObject[] _showObjects;
		}
	}
}
