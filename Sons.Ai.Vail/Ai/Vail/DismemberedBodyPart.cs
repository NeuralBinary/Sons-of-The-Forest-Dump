using System;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Ai.Vail
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[AddComponentMenu("Sons/Weapon/DismemberedBodyPart")]
	public class DismemberedBodyPart : VailCoopObject, IDismember
	{
		// Token: 0x06000439 RID: 1081 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000439")]
		[Address(RVA = "0x2B11030", Offset = "0x2B0F630", VA = "0x182B11030", Slot = "323")]
		protected override void Awake()
		{
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043A")]
		[Address(RVA = "0x2B111D0", Offset = "0x2B0F7D0", VA = "0x182B111D0")]
		private void OnValidate()
		{
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043B")]
		[Address(RVA = "0x2B113A0", Offset = "0x2B0F9A0", VA = "0x182B113A0")]
		public void SetMaterial(VailActorTypeId typeId)
		{
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043C")]
		[Address(RVA = "0x2B113B0", Offset = "0x2B0F9B0", VA = "0x182B113B0")]
		private void OnRenderableLoaded(Transform renderableTransform)
		{
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043D")]
		[Address(RVA = "0x2B11460", Offset = "0x2B0FA60", VA = "0x182B11460")]
		private void ApplyToRenderer()
		{
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043E")]
		[Address(RVA = "0x2B113A0", Offset = "0x2B0F9A0", VA = "0x182B113A0", Slot = "325")]
		private void OnDismember(int sourceActorType)
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600043F")]
		[Address(RVA = "0x2B11550", Offset = "0x2B0FB50", VA = "0x182B11550")]
		[ContextMenu("Find Renderer in Children")]
		private void FindRenderer()
		{
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000440")]
		[Address(RVA = "0x2B115E0", Offset = "0x2B0FBE0", VA = "0x182B115E0")]
		public DismemberedBodyPart()
		{
		}

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private ItemRenderable _itemRenderable;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private DismemberMaterialRenderer _renderer;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Color _bloodReveal;

		// Token: 0x0400036C RID: 876
		[Token(Token = "0x400036C")]
		[FieldOffset(Offset = "0x50")]
		private VailActorTypeId _actorType;
	}
}
