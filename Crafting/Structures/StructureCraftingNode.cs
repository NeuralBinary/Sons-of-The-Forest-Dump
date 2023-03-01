using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Ai.Vail;
using Sons.Inventory;
using Sons.Multiplayer;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007D5 RID: 2005
	[Token(Token = "0x20007D5")]
	[AddComponentMenu("Sons/Crafting/Structures/StructureCraftingNode")]
	public class StructureCraftingNode : BoltEntityBehaviourWrapper<IStructureCraftingNodeState>, IVailCraftingNode
	{
		// Token: 0x170006C2 RID: 1730
		// (get) Token: 0x060034EA RID: 13546 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C2")]
		public StructureRecipe Recipe
		{
			[Token(Token = "0x60034EA")]
			[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006C3 RID: 1731
		// (get) Token: 0x060034EB RID: 13547 RVA: 0x0000F180 File Offset: 0x0000D380
		[Token(Token = "0x170006C3")]
		private bool IsFreeFormStructure
		{
			[Token(Token = "0x60034EB")]
			[Address(RVA = "0x2EA2B20", Offset = "0x2EA1B20", VA = "0x182EA2B20")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006C4 RID: 1732
		// (get) Token: 0x060034EC RID: 13548 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060034ED RID: 13549 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170006C4")]
		public GroundOffsetProvider GroundOffsetProvider
		{
			[Token(Token = "0x60034EC")]
			[Address(RVA = "0x5B3100", Offset = "0x5B2100", VA = "0x1805B3100")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60034ED")]
			[Address(RVA = "0x6920C0", Offset = "0x6910C0", VA = "0x1806920C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170006C5 RID: 1733
		// (get) Token: 0x060034EE RID: 13550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006C5")]
		private StructureCraftingSystem StructureCraftingSystem
		{
			[Token(Token = "0x60034EE")]
			[Address(RVA = "0x2EA2BA0", Offset = "0x2EA1BA0", VA = "0x182EA2BA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x060034EF RID: 13551 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034EF")]
		[Address(RVA = "0x2EA02F0", Offset = "0x2E9F2F0", VA = "0x182EA02F0")]
		private void InitColliders()
		{
		}

		// Token: 0x060034F0 RID: 13552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034F0")]
		[Address(RVA = "0x2E9EEC0", Offset = "0x2E9DEC0", VA = "0x182E9EEC0")]
		public List<BoxCollider> GetColliders()
		{
			return null;
		}

		// Token: 0x060034F1 RID: 13553 RVA: 0x0000F198 File Offset: 0x0000D398
		[Token(Token = "0x60034F1")]
		[Address(RVA = "0x2E9F970", Offset = "0x2E9E970", VA = "0x182E9F970")]
		public float GetMaxDiameter()
		{
			return default(float);
		}

		// Token: 0x060034F2 RID: 13554 RVA: 0x0000F1B0 File Offset: 0x0000D3B0
		[Token(Token = "0x60034F2")]
		[Address(RVA = "0x2E9EF60", Offset = "0x2E9DF60", VA = "0x182E9EF60")]
		public float GetDepthOnAxis(Transform axisTr, Vector3 depthAxis)
		{
			return default(float);
		}

		// Token: 0x060034F3 RID: 13555 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F3")]
		[Address(RVA = "0x2EA0F00", Offset = "0x2E9FF00", VA = "0x182EA0F00")]
		public static void ShowAllGhostsDebug(bool enable)
		{
		}

		// Token: 0x060034F4 RID: 13556 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F4")]
		[Address(RVA = "0x2EA0F50", Offset = "0x2E9FF50", VA = "0x182EA0F50")]
		public static void ShowAllGhosts(bool enable, bool storeValue = false)
		{
		}

		// Token: 0x060034F5 RID: 13557 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F5")]
		[Address(RVA = "0x2EA19C0", Offset = "0x2EA09C0", VA = "0x182EA19C0")]
		private void Start()
		{
		}

		// Token: 0x060034F6 RID: 13558 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F6")]
		[Address(RVA = "0x2EA06B0", Offset = "0x2E9F6B0", VA = "0x182EA06B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060034F7 RID: 13559 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F7")]
		[Address(RVA = "0x2EA0840", Offset = "0x2E9F840", VA = "0x182EA0840")]
		private void OnEnable()
		{
		}

		// Token: 0x060034F8 RID: 13560 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F8")]
		[Address(RVA = "0x2EA0780", Offset = "0x2E9F780", VA = "0x182EA0780")]
		private void OnDisable()
		{
		}

		// Token: 0x060034F9 RID: 13561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x2E9E300", Offset = "0x2E9D300", VA = "0x182E9E300")]
		public void Activate(bool activate)
		{
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x2EA10D0", Offset = "0x2EA00D0", VA = "0x182EA10D0")]
		public void ShowGhost(bool show)
		{
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x0000F1C8 File Offset: 0x0000D3C8
		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x2EA2470", Offset = "0x2EA1470", VA = "0x182EA2470")]
		public bool TryAddIngredient(int ingredientId, int count = 1, bool byLocalPlayer = true)
		{
			return default(bool);
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x0000F1E0 File Offset: 0x0000D3E0
		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x2EA2710", Offset = "0x2EA1710", VA = "0x182EA2710")]
		public bool TryGetCraftingIngredientLink(int ingredientId, out StructureCraftingNode.CraftingIngredientLink foundLink)
		{
			return default(bool);
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x2E9E830", Offset = "0x2E9D830", VA = "0x182E9E830")]
		public void FinishAddingIngredient(int ingredientId, StructureCraftingNode.CraftingIngredientLink foundLink, int count, bool byLocalPlayer)
		{
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x0000F1F8 File Offset: 0x0000D3F8
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x2EA03E0", Offset = "0x2E9F3E0", VA = "0x182EA03E0")]
		private bool IsStructureComplete()
		{
			return default(bool);
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x2EA1DE0", Offset = "0x2EA0DE0", VA = "0x182EA1DE0")]
		public void StructureCompleted()
		{
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x2E9E4E0", Offset = "0x2E9D4E0", VA = "0x182E9E4E0")]
		public void CancelStructure()
		{
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x2E9FE10", Offset = "0x2E9EE10", VA = "0x182E9FE10")]
		private void GrabEnter()
		{
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003502")]
		[Address(RVA = "0x2EA0040", Offset = "0x2E9F040", VA = "0x182EA0040")]
		private void GrabStay()
		{
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003503")]
		[Address(RVA = "0x2E9FF90", Offset = "0x2E9EF90", VA = "0x182E9FF90")]
		private void GrabExit()
		{
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003504")]
		[Address(RVA = "0x2EA2260", Offset = "0x2EA1260", VA = "0x182EA2260")]
		public void ToggleInteraction(bool enable)
		{
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003505")]
		[Address(RVA = "0x2EA0930", Offset = "0x2E9F930", VA = "0x182EA0930")]
		private void OnInteractAction()
		{
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003506")]
		[Address(RVA = "0x2E9FB30", Offset = "0x2E9EB30", VA = "0x182E9FB30")]
		public void GetNeededIngredientIds(ref List<int> neededIngredientIds)
		{
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x0000F210 File Offset: 0x0000D410
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x2E9E710", Offset = "0x2E9D710", VA = "0x182E9E710")]
		public int CountAddedIngredients()
		{
			return default(int);
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003508")]
		[Address(RVA = "0x2EA0DC0", Offset = "0x2E9FDC0", VA = "0x182EA0DC0")]
		public void SetAddedIngredients(int added)
		{
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x0000F228 File Offset: 0x0000D428
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x2EA2800", Offset = "0x2EA1800", VA = "0x182EA2800")]
		public bool TryGetRemainingAmountOfItem(int itemId, out int outRemainingAmount)
		{
			return default(bool);
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x0000F240 File Offset: 0x0000D440
		[Token(Token = "0x600350A")]
		[Address(RVA = "0x2E9FCD0", Offset = "0x2E9ECD0", VA = "0x182E9FCD0")]
		public int GetNextRequiredIngredientId()
		{
			return default(int);
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350B")]
		[Address(RVA = "0x2EA1230", Offset = "0x2EA0230", VA = "0x182EA1230")]
		private void ShowIngredientUi(bool show)
		{
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350C")]
		[Address(RVA = "0x2EA09D0", Offset = "0x2E9F9D0", VA = "0x182EA09D0")]
		private void OnPlayerInventoryChanged(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350D")]
		[Address(RVA = "0x2EA09E0", Offset = "0x2E9F9E0", VA = "0x182EA09E0")]
		private void RefreshIngredientUI()
		{
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600350E")]
		[Address(RVA = "0x2E9F630", Offset = "0x2E9E630", VA = "0x182E9F630")]
		private List<StructureCraftingRecipeIngredient> GetIngredientsList()
		{
			return null;
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350F")]
		[Address(RVA = "0x2EA0380", Offset = "0x2E9F380", VA = "0x182EA0380")]
		public void InstantBuild()
		{
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003510")]
		[Address(RVA = "0x2E9E310", Offset = "0x2E9D310", VA = "0x182E9E310", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003511")]
		[Address(RVA = "0x2EA0500", Offset = "0x2E9F500", VA = "0x182EA0500")]
		public void NetworkTriggeredNodeUpdate()
		{
		}

		// Token: 0x06003512 RID: 13586 RVA: 0x0000F258 File Offset: 0x0000D458
		[Token(Token = "0x6003512")]
		[Address(RVA = "0x2EA15A0", Offset = "0x2EA05A0", VA = "0x182EA15A0", Slot = "24")]
		private bool GetNextItem(out int itemId, out int count)
		{
			return default(bool);
		}

		// Token: 0x06003513 RID: 13587 RVA: 0x0000F270 File Offset: 0x0000D470
		[Token(Token = "0x6003513")]
		[Address(RVA = "0x2EA1680", Offset = "0x2EA0680", VA = "0x182EA1680", Slot = "25")]
		private bool TryAddItem(int itemId, int count)
		{
			return default(bool);
		}

		// Token: 0x06003514 RID: 13588 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003514")]
		[Address(RVA = "0x2EA2A40", Offset = "0x2EA1A40", VA = "0x182EA2A40")]
		public StructureCraftingNode()
		{
		}

		// Token: 0x04002D8E RID: 11662
		[Token(Token = "0x4002D8E")]
		private const string MouseoverEventPath = "event:/SotF Events/player sounds/Inv/MouseOvers/mouseover_";

		// Token: 0x04002D8F RID: 11663
		[Token(Token = "0x4002D8F")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StructureRecipe _recipe;

		// Token: 0x04002D90 RID: 11664
		[Token(Token = "0x4002D90")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cancelStructureInteractionElement;

		// Token: 0x04002D91 RID: 11665
		[Token(Token = "0x4002D91")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<StructureCraftingNode.CraftingIngredientLink> _craftingIngredientLinks;

		// Token: 0x04002D92 RID: 11666
		[Token(Token = "0x4002D92")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _ingredientUiTemplate;

		// Token: 0x04002D93 RID: 11667
		[Token(Token = "0x4002D93")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<StructureCraftingNodeIngredientUi> _ingredientUi;

		// Token: 0x04002D94 RID: 11668
		[Token(Token = "0x4002D94")]
		[FieldOffset(Offset = "0x58")]
		private bool _isActive;

		// Token: 0x04002D95 RID: 11669
		[Token(Token = "0x4002D95")]
		[FieldOffset(Offset = "0x59")]
		private bool _pendingDestroy;

		// Token: 0x04002D96 RID: 11670
		[Token(Token = "0x4002D96")]
		[FieldOffset(Offset = "0x5C")]
		private float _maxDiameter;

		// Token: 0x04002D97 RID: 11671
		[Token(Token = "0x4002D97")]
		[FieldOffset(Offset = "0x60")]
		private StructureCraftingSystem _structureCraftingSystem;

		// Token: 0x04002D98 RID: 11672
		[Token(Token = "0x4002D98")]
		[FieldOffset(Offset = "0x68")]
		private List<BoxCollider> _colliders;

		// Token: 0x04002D99 RID: 11673
		[Token(Token = "0x4002D99")]
		[FieldOffset(Offset = "0x70")]
		public Action OnStructureComplete;

		// Token: 0x04002D9A RID: 11674
		[Token(Token = "0x4002D9A")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static bool _ghostsAlwaysOn;

		// Token: 0x04002D9B RID: 11675
		[Token(Token = "0x4002D9B")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<StructureCraftingNode> StructureNodes;

		// Token: 0x020007D6 RID: 2006
		[Token(Token = "0x20007D6")]
		[Serializable]
		public class CraftingIngredientLink
		{
			// Token: 0x170006C6 RID: 1734
			// (get) Token: 0x06003517 RID: 13591 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003518 RID: 13592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006C6")]
			public StructureCraftingRecipeIngredient Ingredient
			{
				[Token(Token = "0x6003517")]
				[Address(RVA = "0x5430A0", Offset = "0x5420A0", VA = "0x1805430A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003518")]
				[Address(RVA = "0x5A85D0", Offset = "0x5A75D0", VA = "0x1805A85D0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170006C7 RID: 1735
			// (get) Token: 0x06003519 RID: 13593 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x0600351A RID: 13594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006C7")]
			public List<GameObject> Renderables
			{
				[Token(Token = "0x6003519")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600351A")]
				[Address(RVA = "0x5A85C0", Offset = "0x5A75C0", VA = "0x1805A85C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170006C8 RID: 1736
			// (get) Token: 0x0600351B RID: 13595 RVA: 0x0000F2A0 File Offset: 0x0000D4A0
			// (set) Token: 0x0600351C RID: 13596 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x170006C8")]
			public int AppliedCount
			{
				[Token(Token = "0x600351B")]
				[Address(RVA = "0x589ED0", Offset = "0x588ED0", VA = "0x180589ED0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x600351C")]
				[Address(RVA = "0x5ED120", Offset = "0x5EC120", VA = "0x1805ED120")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x170006C9 RID: 1737
			// (get) Token: 0x0600351D RID: 13597 RVA: 0x0000F2B8 File Offset: 0x0000D4B8
			[Token(Token = "0x170006C9")]
			public int RemainingCount
			{
				[Token(Token = "0x600351D")]
				[Address(RVA = "0x2E90C20", Offset = "0x2E8FC20", VA = "0x182E90C20")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x170006CA RID: 1738
			// (get) Token: 0x0600351E RID: 13598 RVA: 0x0000F2D0 File Offset: 0x0000D4D0
			[Token(Token = "0x170006CA")]
			public int TotalCount
			{
				[Token(Token = "0x600351E")]
				[Address(RVA = "0x2E90C40", Offset = "0x2E8FC40", VA = "0x182E90C40")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x170006CB RID: 1739
			// (get) Token: 0x0600351F RID: 13599 RVA: 0x0000F2E8 File Offset: 0x0000D4E8
			[Token(Token = "0x170006CB")]
			public bool AllIngredientsApplied
			{
				[Token(Token = "0x600351F")]
				[Address(RVA = "0x2E90BF0", Offset = "0x2E8FBF0", VA = "0x182E90BF0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003520 RID: 13600 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003520")]
			[Address(RVA = "0x2E90540", Offset = "0x2E8F540", VA = "0x182E90540")]
			private void OnValidate()
			{
			}

			// Token: 0x06003521 RID: 13601 RVA: 0x0000F300 File Offset: 0x0000D500
			[Token(Token = "0x6003521")]
			[Address(RVA = "0x2E90AC0", Offset = "0x2E8FAC0", VA = "0x182E90AC0")]
			public bool TryAddIngredient(int ingredientId)
			{
				return default(bool);
			}

			// Token: 0x06003522 RID: 13602 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003522")]
			[Address(RVA = "0x2E901B0", Offset = "0x2E8F1B0", VA = "0x182E901B0")]
			public void AddIngredients(int amount)
			{
			}

			// Token: 0x06003523 RID: 13603 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003523")]
			[Address(RVA = "0x2E90790", Offset = "0x2E8F790", VA = "0x182E90790")]
			public void RefreshVisuals(bool showGhost)
			{
			}

			// Token: 0x06003524 RID: 13604 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003524")]
			[Address(RVA = "0x2E901C0", Offset = "0x2E8F1C0", VA = "0x182E901C0")]
			public void ConvertAppliedIntoPickups(bool use1to1)
			{
			}

			// Token: 0x06003525 RID: 13605 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003525")]
			[Address(RVA = "0x2E90420", Offset = "0x2E8F420", VA = "0x182E90420")]
			public Transform LastAddedTransform()
			{
				return null;
			}

			// Token: 0x06003526 RID: 13606 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003526")]
			[Address(RVA = "0x2E904D0", Offset = "0x2E8F4D0", VA = "0x182E904D0")]
			public Transform NextAddTransform()
			{
				return null;
			}

			// Token: 0x06003527 RID: 13607 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003527")]
			[Address(RVA = "0x2E90B00", Offset = "0x2E8FB00", VA = "0x182E90B00")]
			public CraftingIngredientLink()
			{
			}

			// Token: 0x04002D9F RID: 11679
			[Token(Token = "0x4002D9F")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private List<StructureCraftingNodeIngredient> _ingredients;
		}
	}
}
