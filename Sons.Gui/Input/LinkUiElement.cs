using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Input
{
	// Token: 0x02000068 RID: 104
	[Token(Token = "0x2000068")]
	public class LinkUiElement : MonoBehaviour
	{
		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060002CB RID: 715 RVA: 0x00002790 File Offset: 0x00000990
		// (set) Token: 0x060002CC RID: 716 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000028")]
		public bool IsActive
		{
			[Token(Token = "0x60002CB")]
			[Address(RVA = "0x24F4A60", Offset = "0x24F3060", VA = "0x1824F4A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60002CC")]
			[Address(RVA = "0x24F4A70", Offset = "0x24F3070", VA = "0x1824F4A70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060002CD RID: 717 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CD")]
		[Address(RVA = "0x305C010", Offset = "0x305A610", VA = "0x18305C010")]
		public void SetApplyTexture(bool value)
		{
		}

		// Token: 0x060002CE RID: 718 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CE")]
		[Address(RVA = "0x305C020", Offset = "0x305A620", VA = "0x18305C020")]
		private void OnEnable()
		{
		}

		// Token: 0x060002CF RID: 719 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002CF")]
		[Address(RVA = "0x305C1C0", Offset = "0x305A7C0", VA = "0x18305C1C0")]
		private void OnDisable()
		{
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D0")]
		[Address(RVA = "0x305C270", Offset = "0x305A870", VA = "0x18305C270")]
		public void SetId(string value, bool refresh = false)
		{
		}

		// Token: 0x060002D1 RID: 721 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D1")]
		[Address(RVA = "0x200AC50", Offset = "0x2009250", VA = "0x18200AC50")]
		public void SetWorldSpaceOffset(Vector3 value)
		{
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D2")]
		[Address(RVA = "0x305C330", Offset = "0x305A930", VA = "0x18305C330")]
		public void ManagedUpdate(Transform targetTransform, Vector3 targetPosition)
		{
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D3")]
		[Address(RVA = "0x305C620", Offset = "0x305AC20", VA = "0x18305C620")]
		private void RemoveElement()
		{
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000027A8 File Offset: 0x000009A8
		[Token(Token = "0x60002D4")]
		[Address(RVA = "0x305C690", Offset = "0x305AC90", VA = "0x18305C690")]
		private bool RequestUiElement()
		{
			return default(bool);
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D5")]
		[Address(RVA = "0x305C830", Offset = "0x305AE30", VA = "0x18305C830")]
		private void ShowElement(Vector3 position, Transform targetTransform)
		{
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D6")]
		[Address(RVA = "0x305C9E0", Offset = "0x305AFE0", VA = "0x18305C9E0")]
		private void ApplyTextureAndMaterial()
		{
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D7")]
		[Address(RVA = "0x305CBF0", Offset = "0x305B1F0", VA = "0x18305CBF0")]
		private void ValidateTexture()
		{
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D8")]
		[Address(RVA = "0x305CF20", Offset = "0x305B520", VA = "0x18305CF20")]
		private void ValidateMaterial()
		{
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002D9")]
		[Address(RVA = "0x305D120", Offset = "0x305B720", VA = "0x18305D120")]
		private void ApplyText()
		{
		}

		// Token: 0x060002DA RID: 730 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DA")]
		[Address(RVA = "0x305D2F0", Offset = "0x305B8F0", VA = "0x18305D2F0")]
		public void SetMaterial(Material material)
		{
		}

		// Token: 0x060002DB RID: 731 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DB")]
		[Address(RVA = "0x305D350", Offset = "0x305B950", VA = "0x18305D350")]
		public void SetTexture(Texture texture)
		{
		}

		// Token: 0x060002DC RID: 732 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DC")]
		[Address(RVA = "0x305D3B0", Offset = "0x305B9B0", VA = "0x18305D3B0")]
		public void SetOutlineTexture(Texture texture)
		{
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DD")]
		[Address(RVA = "0x305D410", Offset = "0x305BA10", VA = "0x18305D410")]
		public void SetText(string text)
		{
		}

		// Token: 0x060002DE RID: 734 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x60002DE")]
		[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
		public GameObject GetUiGameObject()
		{
			return null;
		}

		// Token: 0x060002DF RID: 735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60002DF")]
		[Address(RVA = "0x305D470", Offset = "0x305BA70", VA = "0x18305D470")]
		public LinkUiElement()
		{
		}

		// Token: 0x04000240 RID: 576
		[Token(Token = "0x4000240")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int MainTexId;

		// Token: 0x04000241 RID: 577
		[Token(Token = "0x4000241")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int BaseColorMapId;

		// Token: 0x04000242 RID: 578
		[Token(Token = "0x4000242")]
		[FieldOffset(Offset = "0x8")]
		public static List<LinkUiElement> LinkUiElements;

		// Token: 0x04000243 RID: 579
		[Token(Token = "0x4000243")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private string _uiElementId;

		// Token: 0x04000244 RID: 580
		[Token(Token = "0x4000244")]
		[FieldOffset(Offset = "0x28")]
		private int _uiElementIdHash;

		// Token: 0x04000245 RID: 581
		[Token(Token = "0x4000245")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Vector3 _worldSpaceOffset;

		// Token: 0x04000246 RID: 582
		[Token(Token = "0x4000246")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private float _maxDistance;

		// Token: 0x04000247 RID: 583
		[Token(Token = "0x4000247")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private bool _applyMaterial;

		// Token: 0x04000248 RID: 584
		[Token(Token = "0x4000248")]
		[FieldOffset(Offset = "0x3D")]
		[SerializeField]
		private bool _applyTexture;

		// Token: 0x04000249 RID: 585
		[Token(Token = "0x4000249")]
		[FieldOffset(Offset = "0x3E")]
		[SerializeField]
		private bool _applyText;

		// Token: 0x0400024A RID: 586
		[Token(Token = "0x400024A")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Material _material;

		// Token: 0x0400024B RID: 587
		[Token(Token = "0x400024B")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Texture _texture;

		// Token: 0x0400024C RID: 588
		[Token(Token = "0x400024C")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Texture _outlineTexture;

		// Token: 0x0400024D RID: 589
		[Token(Token = "0x400024D")]
		[FieldOffset(Offset = "0x58")]
		[SerializeField]
		private string _text;

		// Token: 0x0400024E RID: 590
		[Token(Token = "0x400024E")]
		[FieldOffset(Offset = "0x60")]
		private Transform _transform;

		// Token: 0x0400024F RID: 591
		[Token(Token = "0x400024F")]
		[FieldOffset(Offset = "0x68")]
		private GameObject _uiGameObject;

		// Token: 0x04000250 RID: 592
		[Token(Token = "0x4000250")]
		[FieldOffset(Offset = "0x70")]
		private bool _dirty;
	}
}
