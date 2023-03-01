using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020007B6 RID: 1974
	[Token(Token = "0x20007B6")]
	[AddComponentMenu("Sons/Crafting/RevealResultingItemDuringCraft")]
	public class RevealResultingItemDuringCraft : MonoBehaviour
	{
		// Token: 0x06003432 RID: 13362 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003432")]
		[Address(RVA = "0x2E677E0", Offset = "0x2E667E0", VA = "0x182E677E0")]
		private void OnValidate()
		{
		}

		// Token: 0x06003433 RID: 13363 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003433")]
		[Address(RVA = "0x2E67970", Offset = "0x2E66970", VA = "0x182E67970")]
		private void Start()
		{
		}

		// Token: 0x06003434 RID: 13364 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003434")]
		[Address(RVA = "0x2E67420", Offset = "0x2E66420", VA = "0x182E67420")]
		private void OnEnable()
		{
		}

		// Token: 0x06003435 RID: 13365 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003435")]
		[Address(RVA = "0x2E672C0", Offset = "0x2E662C0", VA = "0x182E672C0")]
		private void OnDisable()
		{
		}

		// Token: 0x06003436 RID: 13366 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003436")]
		[Address(RVA = "0x2E67010", Offset = "0x2E66010", VA = "0x182E67010")]
		private void OnCraftComplete(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003437 RID: 13367 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003437")]
		[Address(RVA = "0x2E67580", Offset = "0x2E66580", VA = "0x182E67580")]
		private void OnRevealResultingItem(CraftingRecipe recipe)
		{
		}

		// Token: 0x06003438 RID: 13368 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003438")]
		[Address(RVA = "0x2E677F0", Offset = "0x2E667F0", VA = "0x182E677F0")]
		private void ShowObjects(bool show)
		{
		}

		// Token: 0x06003439 RID: 13369 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003439")]
		[Address(RVA = "0x2E67C50", Offset = "0x2E66C50", VA = "0x182E67C50")]
		public RevealResultingItemDuringCraft()
		{
		}

		// Token: 0x04002D26 RID: 11558
		[Token(Token = "0x4002D26")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CraftingRecipe _recipe;

		// Token: 0x04002D27 RID: 11559
		[Token(Token = "0x4002D27")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _objectsToDisableOnReveal;

		// Token: 0x04002D28 RID: 11560
		[Token(Token = "0x4002D28")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _resultingItems;

		// Token: 0x04002D29 RID: 11561
		[Token(Token = "0x4002D29")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _shouldAnimateResultingItem;

		// Token: 0x04002D2A RID: 11562
		[Token(Token = "0x4002D2A")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _shouldRevertTransformAfterAnimation;

		// Token: 0x04002D2B RID: 11563
		[Token(Token = "0x4002D2B")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _shouldReparentDuringAnimation;

		// Token: 0x04002D2C RID: 11564
		[Token(Token = "0x4002D2C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _reparentTarget;

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _localPositionOffset;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Quaternion _localRotationOffset;

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x68")]
		private List<Transform> _originalParents;

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0x70")]
		private List<Vector3> _originalLocalPositions;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[FieldOffset(Offset = "0x78")]
		private List<Quaternion> _originalLocalRotations;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[FieldOffset(Offset = "0x80")]
		private List<Vector3> _originalLocalScales;
	}
}
