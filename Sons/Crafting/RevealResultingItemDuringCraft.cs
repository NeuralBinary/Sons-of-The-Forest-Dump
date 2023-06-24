using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Crafting
{
	// Token: 0x020006C1 RID: 1729
	[Token(Token = "0x20006C1")]
	[AddComponentMenu("Sons/Crafting/RevealResultingItemDuringCraft")]
	public class RevealResultingItemDuringCraft : MonoBehaviour
	{
		// Token: 0x06002DAB RID: 11691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAB")]
		[Address(RVA = "0x343ADF0", Offset = "0x34393F0", VA = "0x18343ADF0")]
		private void OnValidate()
		{
		}

		// Token: 0x06002DAC RID: 11692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAC")]
		[Address(RVA = "0x343AE00", Offset = "0x3439400", VA = "0x18343AE00")]
		private void Start()
		{
		}

		// Token: 0x06002DAD RID: 11693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAD")]
		[Address(RVA = "0x343B240", Offset = "0x3439840", VA = "0x18343B240")]
		private void OnEnable()
		{
		}

		// Token: 0x06002DAE RID: 11694 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAE")]
		[Address(RVA = "0x343B3A0", Offset = "0x34399A0", VA = "0x18343B3A0")]
		private void OnDisable()
		{
		}

		// Token: 0x06002DAF RID: 11695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DAF")]
		[Address(RVA = "0x343B560", Offset = "0x3439B60", VA = "0x18343B560")]
		private void OnCraftComplete(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002DB0 RID: 11696 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB0")]
		[Address(RVA = "0x343B9E0", Offset = "0x3439FE0", VA = "0x18343B9E0")]
		private void OnRevealResultingItem(CraftingRecipe recipe)
		{
		}

		// Token: 0x06002DB1 RID: 11697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB1")]
		[Address(RVA = "0x343BDB0", Offset = "0x343A3B0", VA = "0x18343BDB0")]
		private void ShowObjects(bool show)
		{
		}

		// Token: 0x06002DB2 RID: 11698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002DB2")]
		[Address(RVA = "0x343BF70", Offset = "0x343A570", VA = "0x18343BF70")]
		public RevealResultingItemDuringCraft()
		{
		}

		// Token: 0x040027FA RID: 10234
		[Token(Token = "0x40027FA")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private CraftingRecipe _recipe;

		// Token: 0x040027FB RID: 10235
		[Token(Token = "0x40027FB")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private List<Transform> _objectsToDisableOnReveal;

		// Token: 0x040027FC RID: 10236
		[Token(Token = "0x40027FC")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private List<GameObject> _resultingItems;

		// Token: 0x040027FD RID: 10237
		[Token(Token = "0x40027FD")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private bool _shouldAnimateResultingItem;

		// Token: 0x040027FE RID: 10238
		[Token(Token = "0x40027FE")]
		[FieldOffset(Offset = "0x39")]
		[SerializeField]
		private bool _shouldRevertTransformAfterAnimation;

		// Token: 0x040027FF RID: 10239
		[Token(Token = "0x40027FF")]
		[FieldOffset(Offset = "0x3A")]
		[SerializeField]
		private bool _shouldReparentDuringAnimation;

		// Token: 0x04002800 RID: 10240
		[Token(Token = "0x4002800")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private Transform _reparentTarget;

		// Token: 0x04002801 RID: 10241
		[Token(Token = "0x4002801")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Vector3 _localPositionOffset;

		// Token: 0x04002802 RID: 10242
		[Token(Token = "0x4002802")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		private Quaternion _localRotationOffset;

		// Token: 0x04002803 RID: 10243
		[Token(Token = "0x4002803")]
		[FieldOffset(Offset = "0x68")]
		private List<Transform> _originalParents;

		// Token: 0x04002804 RID: 10244
		[Token(Token = "0x4002804")]
		[FieldOffset(Offset = "0x70")]
		private List<Vector3> _originalLocalPositions;

		// Token: 0x04002805 RID: 10245
		[Token(Token = "0x4002805")]
		[FieldOffset(Offset = "0x78")]
		private List<Quaternion> _originalLocalRotations;

		// Token: 0x04002806 RID: 10246
		[Token(Token = "0x4002806")]
		[FieldOffset(Offset = "0x80")]
		private List<Vector3> _originalLocalScales;
	}
}
