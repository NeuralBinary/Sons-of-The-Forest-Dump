using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Sons.Crafting.Structures;
using Sons.Input;
using TheForest.Items.Inventory;
using UnityEngine;
using UnityEngine.InputSystem;

namespace TheForest.Player.Actions
{
	// Token: 0x02000492 RID: 1170
	[Token(Token = "0x2000492")]
	[AddComponentMenu("Sons/Actions/PlayerStructurePlaceAction")]
	[DefaultExecutionOrder(1000)]
	public class PlayerStructurePlaceAction : MonoBehaviour
	{
		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001D8F RID: 7567 RVA: 0x00008538 File Offset: 0x00006738
		// (set) Token: 0x06001D90 RID: 7568 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000409")]
		public bool InPlacementMode
		{
			[Token(Token = "0x6001D8F")]
			[Address(RVA = "0x1E52250", Offset = "0x1E51250", VA = "0x181E52250")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001D90")]
			[Address(RVA = "0x1E52300", Offset = "0x1E51300", VA = "0x181E52300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001D91 RID: 7569 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D91")]
		[Address(RVA = "0x2D03470", Offset = "0x2D02470", VA = "0x182D03470")]
		private void Start()
		{
		}

		// Token: 0x06001D92 RID: 7570 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D92")]
		[Address(RVA = "0x2D03220", Offset = "0x2D02220", VA = "0x182D03220")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D93")]
		[Address(RVA = "0x2D03050", Offset = "0x2D02050", VA = "0x182D03050")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D94")]
		[Address(RVA = "0x2D02C90", Offset = "0x2D01C90", VA = "0x182D02C90")]
		public void EnterPlacementMode(StructureRecipe recipe)
		{
		}

		// Token: 0x06001D95 RID: 7573 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D95")]
		[Address(RVA = "0x2D02EA0", Offset = "0x2D01EA0", VA = "0x182D02EA0")]
		private void ExitPlacementMode()
		{
		}

		// Token: 0x06001D96 RID: 7574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D96")]
		[Address(RVA = "0x2D03330", Offset = "0x2D02330", VA = "0x182D03330")]
		private void OnPlaceStructureNode()
		{
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D97")]
		[Address(RVA = "0x2D031C0", Offset = "0x2D021C0", VA = "0x182D031C0")]
		private void OnCancelPlacement()
		{
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D98")]
		[Address(RVA = "0x2D03460", Offset = "0x2D02460", VA = "0x182D03460")]
		private void OnPlayerDied(object _)
		{
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001D99")]
		[Address(RVA = "0x2D03890", Offset = "0x2D02890", VA = "0x182D03890")]
		public PlayerStructurePlaceAction()
		{
		}

		// Token: 0x04001BEF RID: 7151
		[Token(Token = "0x4001BEF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ColorUsage(false, true)]
		private Color _invalidPlacementColor;

		// Token: 0x04001BF0 RID: 7152
		[Token(Token = "0x4001BF0")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PlayerStructurePlaceAction.SinglePlaceOperation _defaultPlaceOperation;

		// Token: 0x04001BF1 RID: 7153
		[Token(Token = "0x4001BF1")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayerStructurePlaceAction.TreeStructurePlaceOperation _treeStructurePlaceOperation;

		// Token: 0x04001BF2 RID: 7154
		[Token(Token = "0x4001BF2")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerStructurePlaceAction.MultiplePlaceOperation _multiplePlaceOperation;

		// Token: 0x04001BF3 RID: 7155
		[Token(Token = "0x4001BF3")]
		[FieldOffset(Offset = "0x48")]
		private PlayerStructurePlaceAction.IPlaceOperation _activePlaceOperation;

		// Token: 0x04001BF4 RID: 7156
		[Token(Token = "0x4001BF4")]
		[FieldOffset(Offset = "0x50")]
		private SonsInputMapping.StructureCraftingActions _inputMapping;

		// Token: 0x04001BF5 RID: 7157
		[Token(Token = "0x4001BF5")]
		[FieldOffset(Offset = "0x58")]
		private PlayerInventory _inventory;

		// Token: 0x04001BF6 RID: 7158
		[Token(Token = "0x4001BF6")]
		[FieldOffset(Offset = "0x60")]
		private StructureCraftingSystem _structureCraftingSystem;

		// Token: 0x02000493 RID: 1171
		[Token(Token = "0x2000493")]
		[Serializable]
		public class MultiplePlaceOperation : PlayerStructurePlaceAction.IPlaceOperation
		{
			// Token: 0x1700040A RID: 1034
			// (get) Token: 0x06001D9A RID: 7578 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001D9B RID: 7579 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700040A")]
			public StructureRecipe Recipe
			{
				[Token(Token = "0x6001D9A")]
				[Address(RVA = "0x52F1A0", Offset = "0x52E1A0", VA = "0x18052F1A0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001D9B")]
				[Address(RVA = "0x692A50", Offset = "0x691A50", VA = "0x180692A50")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700040B RID: 1035
			// (get) Token: 0x06001D9C RID: 7580 RVA: 0x00008550 File Offset: 0x00006750
			// (set) Token: 0x06001D9D RID: 7581 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700040B")]
			public bool HasValidPlacementTarget
			{
				[Token(Token = "0x6001D9C")]
				[Address(RVA = "0x86F2E0", Offset = "0x86E2E0", VA = "0x18086F2E0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001D9D")]
				[Address(RVA = "0x86F330", Offset = "0x86E330", VA = "0x18086F330")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700040C RID: 1036
			// (get) Token: 0x06001D9E RID: 7582 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001D9F RID: 7583 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700040C")]
			public Action OnPlaced
			{
				[Token(Token = "0x6001D9E")]
				[Address(RVA = "0x5E9610", Offset = "0x5E8610", VA = "0x1805E9610")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001D9F")]
				[Address(RVA = "0x5E9640", Offset = "0x5E8640", VA = "0x1805E9640")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700040D RID: 1037
			// (get) Token: 0x06001DA0 RID: 7584 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DA1 RID: 7585 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700040D")]
			public Action OnCancelled
			{
				[Token(Token = "0x6001DA0")]
				[Address(RVA = "0x5E9600", Offset = "0x5E8600", VA = "0x1805E9600")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DA1")]
				[Address(RVA = "0x5E9630", Offset = "0x5E8630", VA = "0x1805E9630")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06001DA2 RID: 7586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DA2")]
			[Address(RVA = "0x2D136B0", Offset = "0x2D126B0", VA = "0x182D136B0")]
			public void Init(InputAction placeAction, InputAction primaryAction, InputAction secondaryAction, Action onPlace, Action onCancel)
			{
			}

			// Token: 0x06001DA3 RID: 7587 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DA3")]
			[Address(RVA = "0x2D13AE0", Offset = "0x2D12AE0", VA = "0x182D13AE0", Slot = "6")]
			private void Begin(StructureRecipe recipe)
			{
			}

			// Token: 0x06001DA4 RID: 7588 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DA4")]
			[Address(RVA = "0x2D142B0", Offset = "0x2D132B0", VA = "0x182D142B0", Slot = "7")]
			private void Stop()
			{
			}

			// Token: 0x06001DA5 RID: 7589 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DA5")]
			[Address(RVA = "0x2D13DA0", Offset = "0x2D12DA0", VA = "0x182D13DA0", Slot = "8")]
			private void OnPlace(StructureCraftingSystem structureCraftingSystem)
			{
			}

			// Token: 0x06001DA6 RID: 7590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DA6")]
			[Address(RVA = "0x2D146C0", Offset = "0x2D136C0", VA = "0x182D146C0", Slot = "9")]
			private void Update()
			{
			}

			// Token: 0x06001DA7 RID: 7591 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001DA7")]
			[Address(RVA = "0x2D135C0", Offset = "0x2D125C0", VA = "0x182D135C0")]
			private StructureCraftingNode GetNewPreviewNode(Vector3 position, Quaternion rotation)
			{
				return null;
			}

			// Token: 0x06001DA8 RID: 7592 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DA8")]
			[Address(RVA = "0x2D13350", Offset = "0x2D12350", VA = "0x182D13350")]
			private void CancelPlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DA9 RID: 7593 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DA9")]
			[Address(RVA = "0x2D15A40", Offset = "0x2D14A40", VA = "0x182D15A40")]
			private void ValidatePlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DAA RID: 7594 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DAA")]
			[Address(RVA = "0x2D13730", Offset = "0x2D12730", VA = "0x182D13730")]
			private void LockPoint(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DAB RID: 7595 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DAB")]
			[Address(RVA = "0x2D15A70", Offset = "0x2D14A70", VA = "0x182D15A70")]
			public MultiplePlaceOperation()
			{
			}

			// Token: 0x06001DAC RID: 7596 RVA: 0x00008568 File Offset: 0x00006768
			[Token(Token = "0x6001DAC")]
			[Address(RVA = "0x2D15810", Offset = "0x2D14810", VA = "0x182D15810")]
			[CompilerGenerated]
			private bool <TheForest.Player.Actions.PlayerStructurePlaceAction.IPlaceOperation.Update>g__TryGetHitPoint|26_0(out Vector3 point)
			{
				return default(bool);
			}

			// Token: 0x06001DAD RID: 7597 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DAD")]
			[Address(RVA = "0x2D15780", Offset = "0x2D14780", VA = "0x182D15780")]
			[CompilerGenerated]
			private void <TheForest.Player.Actions.PlayerStructurePlaceAction.IPlaceOperation.Update>g__RefreshUI|26_1()
			{
			}

			// Token: 0x06001DAE RID: 7598 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DAE")]
			[Address(RVA = "0x2D14B50", Offset = "0x2D13B50", VA = "0x182D14B50")]
			[CompilerGenerated]
			private void <TheForest.Player.Actions.PlayerStructurePlaceAction.IPlaceOperation.Update>g__RefreshNodes|26_2(float distanceBetweenPoints)
			{
			}

			// Token: 0x04001BF8 RID: 7160
			[Token(Token = "0x4001BF8")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private LayerMask _placementSurfaceLayerMask;

			// Token: 0x04001BF9 RID: 7161
			[Token(Token = "0x4001BF9")]
			[FieldOffset(Offset = "0x18")]
			private InputAction _placeAction;

			// Token: 0x04001BFA RID: 7162
			[Token(Token = "0x4001BFA")]
			[FieldOffset(Offset = "0x20")]
			private InputAction _primaryAction;

			// Token: 0x04001BFB RID: 7163
			[Token(Token = "0x4001BFB")]
			[FieldOffset(Offset = "0x28")]
			private InputAction _secondaryAction;

			// Token: 0x04001BFC RID: 7164
			[Token(Token = "0x4001BFC")]
			[FieldOffset(Offset = "0x30")]
			private readonly List<Vector3> _points;

			// Token: 0x04001BFD RID: 7165
			[Token(Token = "0x4001BFD")]
			[FieldOffset(Offset = "0x38")]
			private readonly List<List<StructureCraftingNode>> _nodesBetweenPoints;
		}

		// Token: 0x02000494 RID: 1172
		[Token(Token = "0x2000494")]
		public interface IPlaceOperation
		{
			// Token: 0x1700040E RID: 1038
			// (get) Token: 0x06001DAF RID: 7599
			[Token(Token = "0x1700040E")]
			StructureRecipe Recipe
			{
				[Token(Token = "0x6001DAF")]
				get;
			}

			// Token: 0x1700040F RID: 1039
			// (get) Token: 0x06001DB0 RID: 7600
			[Token(Token = "0x1700040F")]
			bool HasValidPlacementTarget
			{
				[Token(Token = "0x6001DB0")]
				get;
			}

			// Token: 0x06001DB1 RID: 7601
			[Token(Token = "0x6001DB1")]
			void Begin(StructureRecipe recipe);

			// Token: 0x06001DB2 RID: 7602
			[Token(Token = "0x6001DB2")]
			void Stop();

			// Token: 0x06001DB3 RID: 7603
			[Token(Token = "0x6001DB3")]
			void OnPlace(StructureCraftingSystem structureCraftingSystem);

			// Token: 0x06001DB4 RID: 7604
			[Token(Token = "0x6001DB4")]
			void Update();
		}

		// Token: 0x02000495 RID: 1173
		[Token(Token = "0x2000495")]
		[Serializable]
		public class SinglePlaceOperation : PlayerStructurePlaceAction.IPlaceOperation
		{
			// Token: 0x17000410 RID: 1040
			// (get) Token: 0x06001DB5 RID: 7605 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DB6 RID: 7606 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000410")]
			public StructureCraftingNode PreviewStructureNode
			{
				[Token(Token = "0x6001DB5")]
				[Address(RVA = "0x7B2340", Offset = "0x7B1340", VA = "0x1807B2340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DB6")]
				[Address(RVA = "0x7B2360", Offset = "0x7B1360", VA = "0x1807B2360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000411 RID: 1041
			// (get) Token: 0x06001DB7 RID: 7607 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DB8 RID: 7608 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000411")]
			public StructureRecipe Recipe
			{
				[Token(Token = "0x6001DB7")]
				[Address(RVA = "0x582960", Offset = "0x581960", VA = "0x180582960", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DB8")]
				[Address(RVA = "0x7B2350", Offset = "0x7B1350", VA = "0x1807B2350")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000412 RID: 1042
			// (get) Token: 0x06001DB9 RID: 7609 RVA: 0x00008580 File Offset: 0x00006780
			// (set) Token: 0x06001DBA RID: 7610 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000412")]
			public bool HasValidPlacementTarget
			{
				[Token(Token = "0x6001DB9")]
				[Address(RVA = "0x8FF740", Offset = "0x8FE740", VA = "0x1808FF740", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001DBA")]
				[Address(RVA = "0x8FF760", Offset = "0x8FE760", VA = "0x1808FF760")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06001DBB RID: 7611 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DBB")]
			[Address(RVA = "0x2D21810", Offset = "0x2D20810", VA = "0x182D21810")]
			public void Init(InputAction rotateAction, InputAction primaryAction, InputAction secondaryAction, Action onPlace, Action onCancel)
			{
			}

			// Token: 0x06001DBC RID: 7612 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DBC")]
			[Address(RVA = "0x2D228F0", Offset = "0x2D218F0", VA = "0x182D228F0", Slot = "6")]
			private void Begin(StructureRecipe recipe)
			{
			}

			// Token: 0x06001DBD RID: 7613 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DBD")]
			[Address(RVA = "0x2D22D20", Offset = "0x2D21D20", VA = "0x182D22D20", Slot = "7")]
			private void Stop()
			{
			}

			// Token: 0x06001DBE RID: 7614 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DBE")]
			[Address(RVA = "0x2D22B00", Offset = "0x2D21B00", VA = "0x182D22B00", Slot = "8")]
			private void OnPlace(StructureCraftingSystem structureCraftingSystem)
			{
			}

			// Token: 0x06001DBF RID: 7615 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DBF")]
			[Address(RVA = "0x2D22E70", Offset = "0x2D21E70", VA = "0x182D22E70", Slot = "9")]
			private void Update()
			{
			}

			// Token: 0x06001DC0 RID: 7616 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DC0")]
			[Address(RVA = "0x2D225A0", Offset = "0x2D215A0", VA = "0x182D225A0")]
			private void ProcessRotationAndAlignment(Vector3 hitNormal)
			{
			}

			// Token: 0x06001DC1 RID: 7617 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DC1")]
			[Address(RVA = "0x2D21A60", Offset = "0x2D20A60", VA = "0x182D21A60")]
			private void PhysicsPlacementLookup(Vector3 actorPosition, out Vector3 hitNormal)
			{
			}

			// Token: 0x06001DC2 RID: 7618 RVA: 0x00008598 File Offset: 0x00006798
			[Token(Token = "0x6001DC2")]
			[Address(RVA = "0x2D215A0", Offset = "0x2D205A0", VA = "0x182D215A0")]
			private bool IgnoreTreeCastTargetValidation(Ray r, Collider c)
			{
				return default(bool);
			}

			// Token: 0x06001DC3 RID: 7619 RVA: 0x000085B0 File Offset: 0x000067B0
			[Token(Token = "0x6001DC3")]
			[Address(RVA = "0x2D20D30", Offset = "0x2D1FD30", VA = "0x182D20D30")]
			private float CalcMaxPlaceDistance()
			{
				return default(float);
			}

			// Token: 0x06001DC4 RID: 7620 RVA: 0x000085C8 File Offset: 0x000067C8
			[Token(Token = "0x6001DC4")]
			[Address(RVA = "0x2D20D60", Offset = "0x2D1FD60", VA = "0x182D20D60")]
			private bool CheckIfPlacementSpaceIsValid(StructureCraftingNode previewNode)
			{
				return default(bool);
			}

			// Token: 0x06001DC5 RID: 7621 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DC5")]
			[Address(RVA = "0x1A248B0", Offset = "0x1A238B0", VA = "0x181A248B0")]
			private void CancelPlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DC6 RID: 7622 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DC6")]
			[Address(RVA = "0x2D23170", Offset = "0x2D22170", VA = "0x182D23170")]
			private void ValidatePlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DC7 RID: 7623 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DC7")]
			[Address(RVA = "0x2D21670", Offset = "0x2D20670", VA = "0x182D21670")]
			private void InitPreviewStructure(StructureRecipe structureRecipe)
			{
			}

			// Token: 0x06001DC8 RID: 7624 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DC8")]
			[Address(RVA = "0x2D213E0", Offset = "0x2D203E0", VA = "0x182D213E0")]
			private void CleanUpPreviewStructrure()
			{
			}

			// Token: 0x06001DC9 RID: 7625 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DC9")]
			[Address(RVA = "0x2D214A0", Offset = "0x2D204A0", VA = "0x182D214A0")]
			public void CleanUp()
			{
			}

			// Token: 0x06001DCA RID: 7626 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DCA")]
			[Address(RVA = "0x2D231A0", Offset = "0x2D221A0", VA = "0x182D231A0")]
			public SinglePlaceOperation()
			{
			}

			// Token: 0x04001C02 RID: 7170
			[Token(Token = "0x4001C02")]
			[FieldOffset(Offset = "0x10")]
			[Min(3f)]
			[SerializeField]
			private float _maxPlacementRange;

			// Token: 0x04001C03 RID: 7171
			[Token(Token = "0x4001C03")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _rotationSpeed;

			// Token: 0x04001C04 RID: 7172
			[Token(Token = "0x4001C04")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _placementRayAngleOffset;

			// Token: 0x04001C05 RID: 7173
			[Token(Token = "0x4001C05")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private LayerMask _placementSurfaceLayerMask;

			// Token: 0x04001C06 RID: 7174
			[Token(Token = "0x4001C06")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private LayerMask _invalidOverlapsLayerMask;

			// Token: 0x04001C07 RID: 7175
			[Token(Token = "0x4001C07")]
			[FieldOffset(Offset = "0x24")]
			[Range(0f, 1f)]
			[SerializeField]
			private float _placementBoundsThreshold;

			// Token: 0x04001C08 RID: 7176
			[Token(Token = "0x4001C08")]
			[FieldOffset(Offset = "0x28")]
			private InputAction _rotateAction;

			// Token: 0x04001C09 RID: 7177
			[Token(Token = "0x4001C09")]
			[FieldOffset(Offset = "0x30")]
			private InputAction _primaryAction;

			// Token: 0x04001C0A RID: 7178
			[Token(Token = "0x4001C0A")]
			[FieldOffset(Offset = "0x38")]
			private InputAction _secondaryAction;

			// Token: 0x04001C0B RID: 7179
			[Token(Token = "0x4001C0B")]
			[FieldOffset(Offset = "0x40")]
			private Action _onPlaced;

			// Token: 0x04001C0C RID: 7180
			[Token(Token = "0x4001C0C")]
			[FieldOffset(Offset = "0x48")]
			private Action _onCancelled;

			// Token: 0x04001C0D RID: 7181
			[Token(Token = "0x4001C0D")]
			[FieldOffset(Offset = "0x50")]
			private Transform _rayTransform;

			// Token: 0x04001C0E RID: 7182
			[Token(Token = "0x4001C0E")]
			[FieldOffset(Offset = "0x58")]
			private Transform _placementTargetRoot;

			// Token: 0x04001C0F RID: 7183
			[Token(Token = "0x4001C0F")]
			[FieldOffset(Offset = "0x60")]
			private Transform _placementTargetTransform;

			// Token: 0x04001C10 RID: 7184
			[Token(Token = "0x4001C10")]
			[FieldOffset(Offset = "0x68")]
			private BoxCollider _placementTargetCollider;

			// Token: 0x04001C11 RID: 7185
			[Token(Token = "0x4001C11")]
			[FieldOffset(Offset = "0x70")]
			private Transform _colliderCenter;

			// Token: 0x04001C12 RID: 7186
			[Token(Token = "0x4001C12")]
			[FieldOffset(Offset = "0x78")]
			private readonly Collider[] _overlappingPlacementBounds;

			// Token: 0x04001C13 RID: 7187
			[Token(Token = "0x4001C13")]
			[FieldOffset(Offset = "0x80")]
			private float _rotationAnglesDegrees;
		}

		// Token: 0x02000496 RID: 1174
		[Token(Token = "0x2000496")]
		[Serializable]
		public class TreeStructurePlaceOperation : PlayerStructurePlaceAction.IPlaceOperation
		{
			// Token: 0x17000413 RID: 1043
			// (get) Token: 0x06001DCB RID: 7627 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000413")]
			public StructureCraftingNode PreviewStructureNode
			{
				[Token(Token = "0x6001DCB")]
				[Address(RVA = "0x656130", Offset = "0x655130", VA = "0x180656130")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DCC")]
				[Address(RVA = "0x656140", Offset = "0x655140", VA = "0x180656140")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06001DCD RID: 7629 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DCE RID: 7630 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000414")]
			public StructureRecipe Recipe
			{
				[Token(Token = "0x6001DCD")]
				[Address(RVA = "0x5B3100", Offset = "0x5B2100", VA = "0x1805B3100", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DCE")]
				[Address(RVA = "0x6920C0", Offset = "0x6910C0", VA = "0x1806920C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06001DCF RID: 7631 RVA: 0x000085E0 File Offset: 0x000067E0
			// (set) Token: 0x06001DD0 RID: 7632 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000415")]
			public bool HasValidPlacementTarget
			{
				[Token(Token = "0x6001DCF")]
				[Address(RVA = "0x20452A0", Offset = "0x20442A0", VA = "0x1820452A0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001DD0")]
				[Address(RVA = "0x2180920", Offset = "0x217F920", VA = "0x182180920")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DD2 RID: 7634 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000416")]
			public Transform TargetTree
			{
				[Token(Token = "0x6001DD1")]
				[Address(RVA = "0x7B2340", Offset = "0x7B1340", VA = "0x1807B2340")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DD2")]
				[Address(RVA = "0x7B2360", Offset = "0x7B1360", VA = "0x1807B2360")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06001DD3 RID: 7635 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DD3")]
			[Address(RVA = "0x2D23A50", Offset = "0x2D22A50", VA = "0x182D23A50")]
			public void Init(InputAction rotateAction, InputAction primaryAction, InputAction secondaryAction, Action onPlace, Action onCancel)
			{
			}

			// Token: 0x06001DD4 RID: 7636 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DD4")]
			[Address(RVA = "0x2D23F90", Offset = "0x2D22F90", VA = "0x182D23F90", Slot = "6")]
			private void Begin(StructureRecipe recipe)
			{
			}

			// Token: 0x06001DD5 RID: 7637 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DD5")]
			[Address(RVA = "0x2D24430", Offset = "0x2D23430", VA = "0x182D24430", Slot = "7")]
			private void Stop()
			{
			}

			// Token: 0x06001DD6 RID: 7638 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DD6")]
			[Address(RVA = "0x2D241A0", Offset = "0x2D231A0", VA = "0x182D241A0", Slot = "8")]
			private void OnPlace(StructureCraftingSystem structureCraftingSystem)
			{
			}

			// Token: 0x06001DD7 RID: 7639 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DD7")]
			[Address(RVA = "0x2D24580", Offset = "0x2D23580", VA = "0x182D24580", Slot = "9")]
			private void Update()
			{
			}

			// Token: 0x06001DD8 RID: 7640 RVA: 0x000085F8 File Offset: 0x000067F8
			[Token(Token = "0x6001DD8")]
			[Address(RVA = "0x2D24E80", Offset = "0x2D23E80", VA = "0x182D24E80")]
			private bool TryGetHitPoint(out Vector3 point, out Vector3 normal)
			{
				return default(bool);
			}

			// Token: 0x06001DD9 RID: 7641 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DD9")]
			[Address(RVA = "0x2D23BE0", Offset = "0x2D22BE0", VA = "0x182D23BE0")]
			private void ProcessRotationAndAlignment(Vector3 actorPosition, Vector3 hitNormal)
			{
			}

			// Token: 0x06001DDA RID: 7642 RVA: 0x00008610 File Offset: 0x00006810
			[Token(Token = "0x6001DDA")]
			[Address(RVA = "0x2D23210", Offset = "0x2D22210", VA = "0x182D23210")]
			private float CalcMaxPlaceDistance()
			{
				return default(float);
			}

			// Token: 0x06001DDB RID: 7643 RVA: 0x00008628 File Offset: 0x00006828
			[Token(Token = "0x6001DDB")]
			[Address(RVA = "0x2D23240", Offset = "0x2D22240", VA = "0x182D23240")]
			private bool CheckIfPlacementSpaceIsValid(StructureCraftingNode previewNode, out Transform closestTreeTr)
			{
				return default(bool);
			}

			// Token: 0x06001DDC RID: 7644 RVA: 0x00008640 File Offset: 0x00006840
			[Token(Token = "0x6001DDC")]
			[Address(RVA = "0x2D24C00", Offset = "0x2D23C00", VA = "0x182D24C00")]
			private bool TryFindTree(int hitCount, ref float closestTreeDist, ref Transform closestTreeTr)
			{
				return default(bool);
			}

			// Token: 0x06001DDD RID: 7645 RVA: 0x00008658 File Offset: 0x00006858
			[Token(Token = "0x6001DDD")]
			[Address(RVA = "0x2D252D0", Offset = "0x2D242D0", VA = "0x182D252D0")]
			private bool TrySnapToTree(Transform closestTreeTr, Vector3 actorPosition)
			{
				return default(bool);
			}

			// Token: 0x06001DDE RID: 7646 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DDE")]
			[Address(RVA = "0x1A248B0", Offset = "0x1A238B0", VA = "0x181A248B0")]
			private void CancelPlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DDF RID: 7647 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DDF")]
			[Address(RVA = "0x2D23170", Offset = "0x2D22170", VA = "0x182D23170")]
			private void ValidatePlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DE0 RID: 7648 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DE0")]
			[Address(RVA = "0x2D238B0", Offset = "0x2D228B0", VA = "0x182D238B0")]
			private void InitPreviewStructure(StructureRecipe structureRecipe)
			{
			}

			// Token: 0x06001DE1 RID: 7649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DE1")]
			[Address(RVA = "0x2D23760", Offset = "0x2D22760", VA = "0x182D23760")]
			private void CleanUpPreviewStructrure()
			{
			}

			// Token: 0x06001DE2 RID: 7650 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DE2")]
			[Address(RVA = "0x2D23810", Offset = "0x2D22810", VA = "0x182D23810")]
			public void CleanUp()
			{
			}

			// Token: 0x06001DE3 RID: 7651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DE3")]
			[Address(RVA = "0x2D25650", Offset = "0x2D24650", VA = "0x182D25650")]
			public TreeStructurePlaceOperation()
			{
			}

			// Token: 0x04001C17 RID: 7191
			[Token(Token = "0x4001C17")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Min(3f)]
			private float _maxPlacementRange;

			// Token: 0x04001C18 RID: 7192
			[Token(Token = "0x4001C18")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _rotationSpeed;

			// Token: 0x04001C19 RID: 7193
			[Token(Token = "0x4001C19")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private LayerMask _placementSurfaceLayerMask;

			// Token: 0x04001C1A RID: 7194
			[Token(Token = "0x4001C1A")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private LayerMask _invalidOverlapsLayerMask;

			// Token: 0x04001C1B RID: 7195
			[Token(Token = "0x4001C1B")]
			[FieldOffset(Offset = "0x20")]
			[Range(0f, 1f)]
			[SerializeField]
			private float _placementBoundsThreshold;

			// Token: 0x04001C1C RID: 7196
			[Token(Token = "0x4001C1C")]
			[FieldOffset(Offset = "0x28")]
			private InputAction _rotateAction;

			// Token: 0x04001C1D RID: 7197
			[Token(Token = "0x4001C1D")]
			[FieldOffset(Offset = "0x30")]
			private InputAction _primaryAction;

			// Token: 0x04001C1E RID: 7198
			[Token(Token = "0x4001C1E")]
			[FieldOffset(Offset = "0x38")]
			private InputAction _secondaryAction;

			// Token: 0x04001C1F RID: 7199
			[Token(Token = "0x4001C1F")]
			[FieldOffset(Offset = "0x40")]
			private Action _onPlaced;

			// Token: 0x04001C20 RID: 7200
			[Token(Token = "0x4001C20")]
			[FieldOffset(Offset = "0x48")]
			private Action _onCancelled;

			// Token: 0x04001C21 RID: 7201
			[Token(Token = "0x4001C21")]
			[FieldOffset(Offset = "0x50")]
			private Transform _placementTargetTransform;

			// Token: 0x04001C22 RID: 7202
			[Token(Token = "0x4001C22")]
			[FieldOffset(Offset = "0x58")]
			private BoxCollider _placementTargetCollider;

			// Token: 0x04001C23 RID: 7203
			[Token(Token = "0x4001C23")]
			[FieldOffset(Offset = "0x60")]
			private float _structureRotation;

			// Token: 0x04001C24 RID: 7204
			[Token(Token = "0x4001C24")]
			[FieldOffset(Offset = "0x68")]
			private readonly Collider[] _overlappingPlacementBounds;
		}
	}
}
