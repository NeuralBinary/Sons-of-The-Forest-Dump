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
	// Token: 0x020006E1 RID: 1761
	[Token(Token = "0x20006E1")]
	[AddComponentMenu("Sons/Crafting/Structures/StructureCraftingNode")]
	public class StructureCraftingNode : BoltEntityBehaviourWrapper<IStructureCraftingNodeState>, IVailCraftingNode
	{
		// Token: 0x17000631 RID: 1585
		// (get) Token: 0x06002E7E RID: 11902 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000631")]
		public StructureRecipe Recipe
		{
			[Token(Token = "0x6002E7E")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000632 RID: 1586
		// (get) Token: 0x06002E7F RID: 11903 RVA: 0x0000DB00 File Offset: 0x0000BD00
		[Token(Token = "0x17000632")]
		private bool IsFreeFormStructure
		{
			[Token(Token = "0x6002E7F")]
			[Address(RVA = "0x344E140", Offset = "0x344C740", VA = "0x18344E140")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000633 RID: 1587
		// (get) Token: 0x06002E80 RID: 11904 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002E81 RID: 11905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000633")]
		public GroundOffsetProvider GroundOffsetProvider
		{
			[Token(Token = "0x6002E80")]
			[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002E81")]
			[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000634 RID: 1588
		// (get) Token: 0x06002E82 RID: 11906 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000634")]
		private StructureCraftingSystem StructureCraftingSystem
		{
			[Token(Token = "0x6002E82")]
			[Address(RVA = "0x344E220", Offset = "0x344C820", VA = "0x18344E220")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E83")]
		[Address(RVA = "0x344E360", Offset = "0x344C960", VA = "0x18344E360")]
		private void InitColliders()
		{
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E84")]
		[Address(RVA = "0x344E4B0", Offset = "0x344CAB0", VA = "0x18344E4B0")]
		public List<BoxCollider> GetColliders()
		{
			return null;
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x0000DB18 File Offset: 0x0000BD18
		[Token(Token = "0x6002E85")]
		[Address(RVA = "0x344E610", Offset = "0x344CC10", VA = "0x18344E610")]
		public float GetMaxDiameter()
		{
			return 0f;
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x0000DB30 File Offset: 0x0000BD30
		[Token(Token = "0x6002E86")]
		[Address(RVA = "0x344E890", Offset = "0x344CE90", VA = "0x18344E890")]
		public float GetDepthOnAxis(Transform axisTr, Vector3 depthAxis)
		{
			return 0f;
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E87")]
		[Address(RVA = "0x344F3E0", Offset = "0x344D9E0", VA = "0x18344F3E0")]
		public static void ShowAllGhostsDebug(bool enable)
		{
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E88")]
		[Address(RVA = "0x344F430", Offset = "0x344DA30", VA = "0x18344F430")]
		public static void ShowAllGhosts(bool enable, bool storeValue = false)
		{
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E89")]
		[Address(RVA = "0x344F5E0", Offset = "0x344DBE0", VA = "0x18344F5E0")]
		private void Start()
		{
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8A")]
		[Address(RVA = "0x344FFC0", Offset = "0x344E5C0", VA = "0x18344FFC0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8B")]
		[Address(RVA = "0x344BDA0", Offset = "0x344A3A0", VA = "0x18344BDA0")]
		private void OnEnable()
		{
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8C")]
		[Address(RVA = "0x344BE50", Offset = "0x344A450", VA = "0x18344BE50")]
		private void OnDisable()
		{
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8D")]
		[Address(RVA = "0x3450090", Offset = "0x344E690", VA = "0x183450090")]
		public void Activate(bool activate)
		{
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E8E")]
		[Address(RVA = "0x34500A0", Offset = "0x344E6A0", VA = "0x1834500A0")]
		public void ShowGhost(bool show)
		{
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x0000DB48 File Offset: 0x0000BD48
		[Token(Token = "0x6002E8F")]
		[Address(RVA = "0x3450230", Offset = "0x344E830", VA = "0x183450230")]
		public bool TryAddIngredient(int ingredientId, int count = 1, bool byLocalPlayer = true)
		{
			return default(bool);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x0000DB60 File Offset: 0x0000BD60
		[Token(Token = "0x6002E90")]
		[Address(RVA = "0x34505A0", Offset = "0x344EBA0", VA = "0x1834505A0")]
		public bool TryGetCraftingIngredientLink(int ingredientId, out StructureCraftingNode.CraftingIngredientLink foundLink)
		{
			return default(bool);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E91")]
		[Address(RVA = "0x34506D0", Offset = "0x344ECD0", VA = "0x1834506D0")]
		public void FinishAddingIngredient(int ingredientId, StructureCraftingNode.CraftingIngredientLink foundLink, int count, bool byLocalPlayer)
		{
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x0000DB78 File Offset: 0x0000BD78
		[Token(Token = "0x6002E92")]
		[Address(RVA = "0x3450E50", Offset = "0x344F450", VA = "0x183450E50")]
		private bool IsStructureComplete()
		{
			return default(bool);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E93")]
		[Address(RVA = "0x3450FB0", Offset = "0x344F5B0", VA = "0x183450FB0")]
		public void StructureCompleted()
		{
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E94")]
		[Address(RVA = "0x34517E0", Offset = "0x344FDE0", VA = "0x1834517E0")]
		public void CancelStructure()
		{
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E95")]
		[Address(RVA = "0x3451B50", Offset = "0x3450150", VA = "0x183451B50")]
		private void GrabEnter()
		{
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E96")]
		[Address(RVA = "0x3451D20", Offset = "0x3450320", VA = "0x183451D20")]
		private void GrabStay()
		{
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E97")]
		[Address(RVA = "0x3452100", Offset = "0x3450700", VA = "0x183452100")]
		private void GrabExit()
		{
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E98")]
		[Address(RVA = "0x3452240", Offset = "0x3450840", VA = "0x183452240")]
		public void ToggleInteraction(bool enable)
		{
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E99")]
		[Address(RVA = "0x3452530", Offset = "0x3450B30", VA = "0x183452530")]
		private void OnInteractAction()
		{
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E9A")]
		[Address(RVA = "0x3452630", Offset = "0x3450C30", VA = "0x183452630")]
		public void GetNeededIngredientIds(ref List<int> neededIngredientIds)
		{
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x0000DB90 File Offset: 0x0000BD90
		[Token(Token = "0x6002E9B")]
		[Address(RVA = "0x34527F0", Offset = "0x3450DF0", VA = "0x1834527F0")]
		public int CountAddedIngredients()
		{
			return 0;
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E9C")]
		[Address(RVA = "0x3452950", Offset = "0x3450F50", VA = "0x183452950")]
		public void SetAddedIngredients(int added, bool refreshVisuals = true)
		{
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
		[Token(Token = "0x6002E9D")]
		[Address(RVA = "0x3452AD0", Offset = "0x34510D0", VA = "0x183452AD0")]
		public bool TryGetRemainingAmountOfItem(int itemId, out int outRemainingAmount)
		{
			return default(bool);
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x0000DBC0 File Offset: 0x0000BDC0
		[Token(Token = "0x6002E9E")]
		[Address(RVA = "0x3452C40", Offset = "0x3451240", VA = "0x183452C40")]
		private int GetRemainingAmountOfLogs()
		{
			return 0;
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x0000DBD8 File Offset: 0x0000BDD8
		[Token(Token = "0x6002E9F")]
		[Address(RVA = "0x3452E40", Offset = "0x3451440", VA = "0x183452E40")]
		public int GetNextRequiredIngredientId()
		{
			return 0;
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA0")]
		[Address(RVA = "0x3452FA0", Offset = "0x34515A0", VA = "0x183452FA0")]
		private void ShowIngredientUi(bool show)
		{
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA1")]
		[Address(RVA = "0x3453410", Offset = "0x3451A10", VA = "0x183453410")]
		private void OnPlayerInventoryChanged(ItemInstance itemInstance, int itemId)
		{
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA2")]
		[Address(RVA = "0x3453420", Offset = "0x3451A20", VA = "0x183453420")]
		private void RefreshIngredientUI()
		{
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EA3")]
		[Address(RVA = "0x3453880", Offset = "0x3451E80", VA = "0x183453880")]
		private List<StructureCraftingRecipeIngredient> GetIngredientsList()
		{
			return null;
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA4")]
		[Address(RVA = "0x3453D00", Offset = "0x3452300", VA = "0x183453D00", Slot = "16")]
		public override void Attached()
		{
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA5")]
		[Address(RVA = "0x3453EB0", Offset = "0x34524B0", VA = "0x183453EB0")]
		public void NetworkTriggeredNodeUpdate()
		{
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x0000DBF0 File Offset: 0x0000BDF0
		[Token(Token = "0x6002EA6")]
		[Address(RVA = "0x34540C0", Offset = "0x34526C0", VA = "0x1834540C0", Slot = "24")]
		private bool GetNextItem(out int itemId, out int count)
		{
			return default(bool);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x0000DC08 File Offset: 0x0000BE08
		[Token(Token = "0x6002EA7")]
		[Address(RVA = "0x3454190", Offset = "0x3452790", VA = "0x183454190", Slot = "25")]
		private bool TryAddItem(int itemId, int count)
		{
			return default(bool);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x0000DC20 File Offset: 0x0000BE20
		[Token(Token = "0x6002EA8")]
		[Address(RVA = "0x3454210", Offset = "0x3452810", VA = "0x183454210")]
		private bool TryAddLogs(int count)
		{
			return default(bool);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002EA9")]
		[Address(RVA = "0x3454610", Offset = "0x3452C10", VA = "0x183454610")]
		public StructureCraftingNode()
		{
		}

		// Token: 0x04002871 RID: 10353
		[Token(Token = "0x4002871")]
		private const string MouseoverEventPath = "event:/SotF Events/player sounds/Inv/MouseOvers/mouseover_";

		// Token: 0x04002872 RID: 10354
		[Token(Token = "0x4002872")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private StructureRecipe _recipe;

		// Token: 0x04002873 RID: 10355
		[Token(Token = "0x4002873")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private GameObject _cancelStructureInteractionElement;

		// Token: 0x04002874 RID: 10356
		[Token(Token = "0x4002874")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private List<StructureCraftingNode.CraftingIngredientLink> _craftingIngredientLinks;

		// Token: 0x04002875 RID: 10357
		[Token(Token = "0x4002875")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private GameObject _ingredientUiTemplate;

		// Token: 0x04002876 RID: 10358
		[Token(Token = "0x4002876")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private List<StructureCraftingNodeIngredientUi> _ingredientUi;

		// Token: 0x04002877 RID: 10359
		[Token(Token = "0x4002877")]
		[FieldOffset(Offset = "0x58")]
		private bool _isActive;

		// Token: 0x04002878 RID: 10360
		[Token(Token = "0x4002878")]
		[FieldOffset(Offset = "0x59")]
		private bool _pendingDestroy;

		// Token: 0x04002879 RID: 10361
		[Token(Token = "0x4002879")]
		[FieldOffset(Offset = "0x5C")]
		private float _maxDiameter;

		// Token: 0x0400287A RID: 10362
		[Token(Token = "0x400287A")]
		[FieldOffset(Offset = "0x60")]
		private StructureCraftingSystem _structureCraftingSystem;

		// Token: 0x0400287B RID: 10363
		[Token(Token = "0x400287B")]
		[FieldOffset(Offset = "0x68")]
		private List<BoxCollider> _colliders;

		// Token: 0x0400287C RID: 10364
		[Token(Token = "0x400287C")]
		[FieldOffset(Offset = "0x70")]
		public Action OnStructureComplete;

		// Token: 0x0400287D RID: 10365
		[Token(Token = "0x400287D")]
		[FieldOffset(Offset = "0x0")]
		[NonSerialized]
		private static bool _ghostsAlwaysOn;

		// Token: 0x0400287E RID: 10366
		[Token(Token = "0x400287E")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<StructureCraftingNode> StructureNodes;

		// Token: 0x020006E2 RID: 1762
		[Token(Token = "0x20006E2")]
		[Serializable]
		public class CraftingIngredientLink
		{
			// Token: 0x17000635 RID: 1589
			// (get) Token: 0x06002EAC RID: 11948 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002EAD RID: 11949 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000635")]
			public StructureCraftingRecipeIngredient Ingredient
			{
				[Token(Token = "0x6002EAC")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002EAD")]
				[Address(RVA = "0x635620", Offset = "0x633C20", VA = "0x180635620")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000636 RID: 1590
			// (get) Token: 0x06002EAE RID: 11950 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06002EAF RID: 11951 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000636")]
			public List<GameObject> Renderables
			{
				[Token(Token = "0x6002EAE")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6002EAF")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000637 RID: 1591
			// (get) Token: 0x06002EB0 RID: 11952 RVA: 0x0000DC50 File Offset: 0x0000BE50
			// (set) Token: 0x06002EB1 RID: 11953 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000637")]
			public int AppliedCount
			{
				[Token(Token = "0x6002EB0")]
				[Address(RVA = "0x632000", Offset = "0x630600", VA = "0x180632000")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x6002EB1")]
				[Address(RVA = "0x670F30", Offset = "0x66F530", VA = "0x180670F30")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000638 RID: 1592
			// (get) Token: 0x06002EB2 RID: 11954 RVA: 0x0000DC68 File Offset: 0x0000BE68
			[Token(Token = "0x17000638")]
			public int RemainingCount
			{
				[Token(Token = "0x6002EB2")]
				[Address(RVA = "0x34549A0", Offset = "0x3452FA0", VA = "0x1834549A0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000639 RID: 1593
			// (get) Token: 0x06002EB3 RID: 11955 RVA: 0x0000DC80 File Offset: 0x0000BE80
			[Token(Token = "0x17000639")]
			public int TotalCount
			{
				[Token(Token = "0x6002EB3")]
				[Address(RVA = "0x34549C0", Offset = "0x3452FC0", VA = "0x1834549C0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x1700063A RID: 1594
			// (get) Token: 0x06002EB4 RID: 11956 RVA: 0x0000DC98 File Offset: 0x0000BE98
			[Token(Token = "0x1700063A")]
			public bool AllIngredientsApplied
			{
				[Token(Token = "0x6002EB4")]
				[Address(RVA = "0x34549E0", Offset = "0x3452FE0", VA = "0x1834549E0")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06002EB5 RID: 11957 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002EB5")]
			[Address(RVA = "0x3454A10", Offset = "0x3453010", VA = "0x183454A10")]
			private void OnValidate()
			{
			}

			// Token: 0x06002EB6 RID: 11958 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
			[Token(Token = "0x6002EB6")]
			[Address(RVA = "0x3454C80", Offset = "0x3453280", VA = "0x183454C80")]
			public bool TryAddIngredient(int ingredientId)
			{
				return default(bool);
			}

			// Token: 0x06002EB7 RID: 11959 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002EB7")]
			[Address(RVA = "0x3454CC0", Offset = "0x34532C0", VA = "0x183454CC0")]
			public void AddIngredients(int amount, bool refreshVisuals = true)
			{
			}

			// Token: 0x06002EB8 RID: 11960 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002EB8")]
			[Address(RVA = "0x3454CE0", Offset = "0x34532E0", VA = "0x183454CE0")]
			public void RefreshVisuals(bool showGhost)
			{
			}

			// Token: 0x06002EB9 RID: 11961 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002EB9")]
			[Address(RVA = "0x34550E0", Offset = "0x34536E0", VA = "0x1834550E0")]
			public void ConvertAppliedIntoPickups(bool use1to1)
			{
			}

			// Token: 0x06002EBA RID: 11962 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002EBA")]
			[Address(RVA = "0x34553E0", Offset = "0x34539E0", VA = "0x1834553E0")]
			public Transform LastAddedTransform()
			{
				return null;
			}

			// Token: 0x06002EBB RID: 11963 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002EBB")]
			[Address(RVA = "0x34554E0", Offset = "0x3453AE0", VA = "0x1834554E0")]
			public Transform NextAddTransform()
			{
				return null;
			}

			// Token: 0x06002EBC RID: 11964 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002EBC")]
			[Address(RVA = "0x34555A0", Offset = "0x3453BA0", VA = "0x1834555A0")]
			public CraftingIngredientLink()
			{
			}

			// Token: 0x04002882 RID: 10370
			[Token(Token = "0x4002882")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private List<StructureCraftingNodeIngredient> _ingredients;
		}
	}
}
