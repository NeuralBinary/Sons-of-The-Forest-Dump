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
	// Token: 0x02000484 RID: 1156
	[Token(Token = "0x2000484")]
	[DefaultExecutionOrder(1000)]
	[AddComponentMenu("Sons/Actions/PlayerStructurePlaceAction")]
	public class PlayerStructurePlaceAction : MonoBehaviour
	{
		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001DD3 RID: 7635 RVA: 0x000087C0 File Offset: 0x000069C0
		// (set) Token: 0x06001DD4 RID: 7636 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000413")]
		public bool InPlacementMode
		{
			[Token(Token = "0x6001DD3")]
			[Address(RVA = "0x612480", Offset = "0x610A80", VA = "0x180612480")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6001DD4")]
			[Address(RVA = "0x612490", Offset = "0x610A90", VA = "0x180612490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06001DD5 RID: 7637 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD5")]
		[Address(RVA = "0x32E2610", Offset = "0x32E0C10", VA = "0x1832E2610")]
		private void Start()
		{
		}

		// Token: 0x06001DD6 RID: 7638 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD6")]
		[Address(RVA = "0x32E2B30", Offset = "0x32E1130", VA = "0x1832E2B30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001DD7 RID: 7639 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD7")]
		[Address(RVA = "0x32E2D40", Offset = "0x32E1340", VA = "0x1832E2D40")]
		private void LateUpdate()
		{
		}

		// Token: 0x06001DD8 RID: 7640 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD8")]
		[Address(RVA = "0x32E3030", Offset = "0x32E1630", VA = "0x1832E3030")]
		public void EnterPlacementMode(StructureRecipe recipe, bool placeBuilt)
		{
		}

		// Token: 0x06001DD9 RID: 7641 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DD9")]
		[Address(RVA = "0x32E32A0", Offset = "0x32E18A0", VA = "0x1832E32A0")]
		private void ExitPlacementMode()
		{
		}

		// Token: 0x06001DDA RID: 7642 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDA")]
		[Address(RVA = "0x32E3510", Offset = "0x32E1B10", VA = "0x1832E3510")]
		private void OnPlaceStructureNode()
		{
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDB")]
		[Address(RVA = "0x32E3660", Offset = "0x32E1C60", VA = "0x1832E3660")]
		public void OnCancelPlacement()
		{
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDC")]
		[Address(RVA = "0x32E3710", Offset = "0x32E1D10", VA = "0x1832E3710")]
		private void OnPlayerDied(object _)
		{
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDD")]
		[Address(RVA = "0x6710D0", Offset = "0x66F6D0", VA = "0x1806710D0")]
		public void SetCustomPlaceAction(IOnPlaceStructureReceiver receiver)
		{
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDE")]
		[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
		public void SetCustomCancelAction(IOnCancelStructureReceiver receiver)
		{
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6001DDF")]
		[Address(RVA = "0x32E3770", Offset = "0x32E1D70", VA = "0x1832E3770")]
		public PlayerStructurePlaceAction()
		{
		}

		// Token: 0x04001C19 RID: 7193
		[Token(Token = "0x4001C19")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[ColorUsage(false, true)]
		private Color _invalidPlacementColor;

		// Token: 0x04001C1A RID: 7194
		[Token(Token = "0x4001C1A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private PlayerStructurePlaceAction.SinglePlaceOperation _defaultPlaceOperation;

		// Token: 0x04001C1B RID: 7195
		[Token(Token = "0x4001C1B")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private PlayerStructurePlaceAction.TreeStructurePlaceOperation _treeStructurePlaceOperation;

		// Token: 0x04001C1C RID: 7196
		[Token(Token = "0x4001C1C")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private PlayerStructurePlaceAction.MultiplePlaceOperation _multiplePlaceOperation;

		// Token: 0x04001C1D RID: 7197
		[Token(Token = "0x4001C1D")]
		[FieldOffset(Offset = "0x48")]
		private IOnPlaceStructureReceiver _onPlaceCustomAction;

		// Token: 0x04001C1E RID: 7198
		[Token(Token = "0x4001C1E")]
		[FieldOffset(Offset = "0x50")]
		private IOnCancelStructureReceiver _onCancelCustomAction;

		// Token: 0x04001C1F RID: 7199
		[Token(Token = "0x4001C1F")]
		[FieldOffset(Offset = "0x58")]
		private PlayerStructurePlaceAction.IPlaceOperation _activePlaceOperation;

		// Token: 0x04001C20 RID: 7200
		[Token(Token = "0x4001C20")]
		[FieldOffset(Offset = "0x60")]
		private SonsInputMapping.StructureCraftingActions _inputMapping;

		// Token: 0x04001C21 RID: 7201
		[Token(Token = "0x4001C21")]
		[FieldOffset(Offset = "0x68")]
		private PlayerInventory _inventory;

		// Token: 0x04001C22 RID: 7202
		[Token(Token = "0x4001C22")]
		[FieldOffset(Offset = "0x70")]
		private StructureCraftingSystem _structureCraftingSystem;

		// Token: 0x02000485 RID: 1157
		[Token(Token = "0x2000485")]
		[Serializable]
		public class MultiplePlaceOperation : PlayerStructurePlaceAction.IPlaceOperation
		{
			// Token: 0x17000414 RID: 1044
			// (get) Token: 0x06001DE0 RID: 7648 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DE1 RID: 7649 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000414")]
			public StructureRecipe Recipe
			{
				[Token(Token = "0x6001DE0")]
				[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DE1")]
				[Address(RVA = "0x5B2560", Offset = "0x5B0B60", VA = "0x1805B2560")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000415 RID: 1045
			// (get) Token: 0x06001DE2 RID: 7650 RVA: 0x000087D8 File Offset: 0x000069D8
			// (set) Token: 0x06001DE3 RID: 7651 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000415")]
			public bool HasValidPlacementTarget
			{
				[Token(Token = "0x6001DE2")]
				[Address(RVA = "0x993BD0", Offset = "0x9921D0", VA = "0x180993BD0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001DE3")]
				[Address(RVA = "0x998EF0", Offset = "0x9974F0", VA = "0x180998EF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000416 RID: 1046
			// (get) Token: 0x06001DE4 RID: 7652 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DE5 RID: 7653 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000416")]
			public Action OnPlaced
			{
				[Token(Token = "0x6001DE4")]
				[Address(RVA = "0x661070", Offset = "0x65F670", VA = "0x180661070")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DE5")]
				[Address(RVA = "0x661080", Offset = "0x65F680", VA = "0x180661080")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000417 RID: 1047
			// (get) Token: 0x06001DE6 RID: 7654 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DE7 RID: 7655 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000417")]
			public Action OnCancelled
			{
				[Token(Token = "0x6001DE6")]
				[Address(RVA = "0x6610E0", Offset = "0x65F6E0", VA = "0x1806610E0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DE7")]
				[Address(RVA = "0x6610F0", Offset = "0x65F6F0", VA = "0x1806610F0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06001DE8 RID: 7656 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DE8")]
			[Address(RVA = "0x32E37C0", Offset = "0x32E1DC0", VA = "0x1832E37C0")]
			public void Init(InputAction placeAction, InputAction primaryAction, InputAction secondaryAction, Action onPlace, Action onCancel)
			{
			}

			// Token: 0x06001DE9 RID: 7657 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DE9")]
			[Address(RVA = "0x32E3980", Offset = "0x32E1F80", VA = "0x1832E3980", Slot = "6")]
			private void Begin(StructureRecipe recipe, bool placeBuilt)
			{
			}

			// Token: 0x06001DEA RID: 7658 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DEA")]
			[Address(RVA = "0x32E3CD0", Offset = "0x32E22D0", VA = "0x1832E3CD0", Slot = "7")]
			private void Stop()
			{
			}

			// Token: 0x06001DEB RID: 7659 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DEB")]
			[Address(RVA = "0x32E4220", Offset = "0x32E2820", VA = "0x1832E4220", Slot = "8")]
			private void OnPlace(StructureCraftingSystem structureCraftingSystem)
			{
			}

			// Token: 0x06001DEC RID: 7660 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DEC")]
			[Address(RVA = "0x32E4920", Offset = "0x32E2F20", VA = "0x1832E4920", Slot = "9")]
			private void Update()
			{
			}

			// Token: 0x06001DED RID: 7661 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6001DED")]
			[Address(RVA = "0x32E4C30", Offset = "0x32E3230", VA = "0x1832E4C30")]
			private StructureCraftingNode GetNewPreviewNode(Vector3 position, Quaternion rotation)
			{
				return null;
			}

			// Token: 0x06001DEE RID: 7662 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DEE")]
			[Address(RVA = "0x32E4D60", Offset = "0x32E3360", VA = "0x1832E4D60")]
			private void CancelPlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DEF RID: 7663 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DEF")]
			[Address(RVA = "0x32E5080", Offset = "0x32E3680", VA = "0x1832E5080")]
			private void ValidatePlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DF0 RID: 7664 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DF0")]
			[Address(RVA = "0x32E50B0", Offset = "0x32E36B0", VA = "0x1832E50B0")]
			private void LockPoint(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001DF1 RID: 7665 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DF1")]
			[Address(RVA = "0x32E5510", Offset = "0x32E3B10", VA = "0x1832E5510")]
			public MultiplePlaceOperation()
			{
			}

			// Token: 0x06001DF2 RID: 7666 RVA: 0x000087F0 File Offset: 0x000069F0
			[Token(Token = "0x6001DF2")]
			[Address(RVA = "0x32E5660", Offset = "0x32E3C60", VA = "0x1832E5660")]
			[CompilerGenerated]
			private bool <TheForest.Player.Actions.PlayerStructurePlaceAction.IPlaceOperation.Update>g__TryGetHitPoint|26_0(out Vector3 point)
			{
				return default(bool);
			}

			// Token: 0x06001DF3 RID: 7667 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DF3")]
			[Address(RVA = "0x32E5950", Offset = "0x32E3F50", VA = "0x1832E5950")]
			[CompilerGenerated]
			private void <TheForest.Player.Actions.PlayerStructurePlaceAction.IPlaceOperation.Update>g__RefreshUI|26_1()
			{
			}

			// Token: 0x06001DF4 RID: 7668 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001DF4")]
			[Address(RVA = "0x32E59E0", Offset = "0x32E3FE0", VA = "0x1832E59E0")]
			[CompilerGenerated]
			private void <TheForest.Player.Actions.PlayerStructurePlaceAction.IPlaceOperation.Update>g__RefreshNodes|26_2(float distanceBetweenPoints)
			{
			}

			// Token: 0x04001C24 RID: 7204
			[Token(Token = "0x4001C24")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private LayerMask _placementSurfaceLayerMask;

			// Token: 0x04001C25 RID: 7205
			[Token(Token = "0x4001C25")]
			[FieldOffset(Offset = "0x18")]
			private InputAction _placeAction;

			// Token: 0x04001C26 RID: 7206
			[Token(Token = "0x4001C26")]
			[FieldOffset(Offset = "0x20")]
			private InputAction _primaryAction;

			// Token: 0x04001C27 RID: 7207
			[Token(Token = "0x4001C27")]
			[FieldOffset(Offset = "0x28")]
			private InputAction _secondaryAction;

			// Token: 0x04001C28 RID: 7208
			[Token(Token = "0x4001C28")]
			[FieldOffset(Offset = "0x30")]
			private readonly List<Vector3> _points;

			// Token: 0x04001C29 RID: 7209
			[Token(Token = "0x4001C29")]
			[FieldOffset(Offset = "0x38")]
			private readonly List<List<StructureCraftingNode>> _nodesBetweenPoints;
		}

		// Token: 0x02000486 RID: 1158
		[Token(Token = "0x2000486")]
		public interface IPlaceOperation
		{
			// Token: 0x17000418 RID: 1048
			// (get) Token: 0x06001DF5 RID: 7669
			[Token(Token = "0x17000418")]
			StructureRecipe Recipe { [Token(Token = "0x6001DF5")] get; }

			// Token: 0x17000419 RID: 1049
			// (get) Token: 0x06001DF6 RID: 7670
			[Token(Token = "0x17000419")]
			bool HasValidPlacementTarget { [Token(Token = "0x6001DF6")] get; }

			// Token: 0x06001DF7 RID: 7671
			[Token(Token = "0x6001DF7")]
			void Begin(StructureRecipe recipe, bool placeBuilt);

			// Token: 0x06001DF8 RID: 7672
			[Token(Token = "0x6001DF8")]
			void Stop();

			// Token: 0x06001DF9 RID: 7673
			[Token(Token = "0x6001DF9")]
			void OnPlace(StructureCraftingSystem structureCraftingSystem);

			// Token: 0x06001DFA RID: 7674
			[Token(Token = "0x6001DFA")]
			void Update();
		}

		// Token: 0x02000487 RID: 1159
		[Token(Token = "0x2000487")]
		[Serializable]
		public class SinglePlaceOperation : PlayerStructurePlaceAction.IPlaceOperation
		{
			// Token: 0x1700041A RID: 1050
			// (get) Token: 0x06001DFB RID: 7675 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DFC RID: 7676 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700041A")]
			public StructureCraftingNode PreviewStructureNode
			{
				[Token(Token = "0x6001DFB")]
				[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DFC")]
				[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700041B RID: 1051
			// (get) Token: 0x06001DFD RID: 7677 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001DFE RID: 7678 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700041B")]
			public StructureRecipe Recipe
			{
				[Token(Token = "0x6001DFD")]
				[Address(RVA = "0x5EE390", Offset = "0x5EC990", VA = "0x1805EE390", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001DFE")]
				[Address(RVA = "0x8DD110", Offset = "0x8DB710", VA = "0x1808DD110")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700041C RID: 1052
			// (get) Token: 0x06001DFF RID: 7679 RVA: 0x00008808 File Offset: 0x00006A08
			// (set) Token: 0x06001E00 RID: 7680 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700041C")]
			public bool HasValidPlacementTarget
			{
				[Token(Token = "0x6001DFF")]
				[Address(RVA = "0xA53170", Offset = "0xA51770", VA = "0x180A53170", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001E00")]
				[Address(RVA = "0xA53180", Offset = "0xA51780", VA = "0x180A53180")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06001E01 RID: 7681 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E01")]
			[Address(RVA = "0x32E6840", Offset = "0x32E4E40", VA = "0x1832E6840")]
			public void Init(InputAction rotateAction, InputAction primaryAction, InputAction secondaryAction, Action onPlace, Action onCancel)
			{
			}

			// Token: 0x06001E02 RID: 7682 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E02")]
			[Address(RVA = "0x32E6EC0", Offset = "0x32E54C0", VA = "0x1832E6EC0", Slot = "6")]
			private void Begin(StructureRecipe recipe, bool placeBuilt)
			{
			}

			// Token: 0x06001E03 RID: 7683 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E03")]
			[Address(RVA = "0x32E7270", Offset = "0x32E5870", VA = "0x1832E7270", Slot = "7")]
			private void Stop()
			{
			}

			// Token: 0x06001E04 RID: 7684 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E04")]
			[Address(RVA = "0x32E7440", Offset = "0x32E5A40", VA = "0x1832E7440", Slot = "8")]
			private void OnPlace(StructureCraftingSystem structureCraftingSystem)
			{
			}

			// Token: 0x06001E05 RID: 7685 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E05")]
			[Address(RVA = "0x32E7880", Offset = "0x32E5E80", VA = "0x1832E7880", Slot = "9")]
			private void Update()
			{
			}

			// Token: 0x06001E06 RID: 7686 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E06")]
			[Address(RVA = "0x32E7D50", Offset = "0x32E6350", VA = "0x1832E7D50")]
			private void ProcessRotationAndAlignment(Vector3 hitNormal)
			{
			}

			// Token: 0x06001E07 RID: 7687 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E07")]
			[Address(RVA = "0x32E8140", Offset = "0x32E6740", VA = "0x1832E8140")]
			private void PhysicsPlacementLookup(Vector3 actorPosition, out Vector3 hitNormal)
			{
			}

			// Token: 0x06001E08 RID: 7688 RVA: 0x00008820 File Offset: 0x00006A20
			[Token(Token = "0x6001E08")]
			[Address(RVA = "0x32E8FA0", Offset = "0x32E75A0", VA = "0x1832E8FA0")]
			private bool IgnoreTreeCastTargetValidation(Ray r, Collider c)
			{
				return default(bool);
			}

			// Token: 0x06001E09 RID: 7689 RVA: 0x00008838 File Offset: 0x00006A38
			[Token(Token = "0x6001E09")]
			[Address(RVA = "0x32E91D0", Offset = "0x32E77D0", VA = "0x1832E91D0")]
			private float CalcMaxPlaceDistance()
			{
				return 0f;
			}

			// Token: 0x06001E0A RID: 7690 RVA: 0x00008850 File Offset: 0x00006A50
			[Token(Token = "0x6001E0A")]
			[Address(RVA = "0x32E9200", Offset = "0x32E7800", VA = "0x1832E9200")]
			private bool CheckIfPlacementSpaceIsValid(StructureCraftingNode previewNode)
			{
				return default(bool);
			}

			// Token: 0x06001E0B RID: 7691 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E0B")]
			[Address(RVA = "0x1D11630", Offset = "0x1D0FC30", VA = "0x181D11630")]
			private void CancelPlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001E0C RID: 7692 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E0C")]
			[Address(RVA = "0x32E9AE0", Offset = "0x32E80E0", VA = "0x1832E9AE0")]
			private void ValidatePlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001E0D RID: 7693 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E0D")]
			[Address(RVA = "0x32E9B10", Offset = "0x32E8110", VA = "0x1832E9B10")]
			private void InitPreviewStructure(StructureRecipe structureRecipe)
			{
			}

			// Token: 0x06001E0E RID: 7694 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E0E")]
			[Address(RVA = "0x32E9E50", Offset = "0x32E8450", VA = "0x1832E9E50")]
			private void CleanUpPreviewStructrure()
			{
			}

			// Token: 0x06001E0F RID: 7695 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E0F")]
			[Address(RVA = "0x32E9FE0", Offset = "0x32E85E0", VA = "0x1832E9FE0")]
			public void CleanUp()
			{
			}

			// Token: 0x06001E10 RID: 7696 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E10")]
			[Address(RVA = "0x32EA210", Offset = "0x32E8810", VA = "0x1832EA210")]
			public SinglePlaceOperation()
			{
			}

			// Token: 0x04001C2E RID: 7214
			[Token(Token = "0x4001C2E")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Min(3f)]
			private float _maxPlacementRange;

			// Token: 0x04001C2F RID: 7215
			[Token(Token = "0x4001C2F")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _rotationSpeed;

			// Token: 0x04001C30 RID: 7216
			[Token(Token = "0x4001C30")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private float _placementRayAngleOffset;

			// Token: 0x04001C31 RID: 7217
			[Token(Token = "0x4001C31")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private LayerMask _placementSurfaceLayerMask;

			// Token: 0x04001C32 RID: 7218
			[Token(Token = "0x4001C32")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			private LayerMask _invalidOverlapsLayerMask;

			// Token: 0x04001C33 RID: 7219
			[Token(Token = "0x4001C33")]
			[FieldOffset(Offset = "0x24")]
			[Range(0f, 1f)]
			[SerializeField]
			private float _placementBoundsThreshold;

			// Token: 0x04001C34 RID: 7220
			[Token(Token = "0x4001C34")]
			[FieldOffset(Offset = "0x28")]
			private InputAction _rotateAction;

			// Token: 0x04001C35 RID: 7221
			[Token(Token = "0x4001C35")]
			[FieldOffset(Offset = "0x30")]
			private InputAction _primaryAction;

			// Token: 0x04001C36 RID: 7222
			[Token(Token = "0x4001C36")]
			[FieldOffset(Offset = "0x38")]
			private InputAction _secondaryAction;

			// Token: 0x04001C37 RID: 7223
			[Token(Token = "0x4001C37")]
			[FieldOffset(Offset = "0x40")]
			private Action _onPlaced;

			// Token: 0x04001C38 RID: 7224
			[Token(Token = "0x4001C38")]
			[FieldOffset(Offset = "0x48")]
			private Action _onCancelled;

			// Token: 0x04001C39 RID: 7225
			[Token(Token = "0x4001C39")]
			[FieldOffset(Offset = "0x50")]
			private Transform _rayTransform;

			// Token: 0x04001C3A RID: 7226
			[Token(Token = "0x4001C3A")]
			[FieldOffset(Offset = "0x58")]
			private Transform _placementTargetRoot;

			// Token: 0x04001C3B RID: 7227
			[Token(Token = "0x4001C3B")]
			[FieldOffset(Offset = "0x60")]
			private Transform _placementTargetTransform;

			// Token: 0x04001C3C RID: 7228
			[Token(Token = "0x4001C3C")]
			[FieldOffset(Offset = "0x68")]
			private BoxCollider _placementTargetCollider;

			// Token: 0x04001C3D RID: 7229
			[Token(Token = "0x4001C3D")]
			[FieldOffset(Offset = "0x70")]
			private Transform _colliderCenter;

			// Token: 0x04001C3E RID: 7230
			[Token(Token = "0x4001C3E")]
			[FieldOffset(Offset = "0x78")]
			private readonly Collider[] _overlappingPlacementBounds;

			// Token: 0x04001C3F RID: 7231
			[Token(Token = "0x4001C3F")]
			[FieldOffset(Offset = "0x80")]
			private float _rotationAnglesDegrees;

			// Token: 0x04001C40 RID: 7232
			[Token(Token = "0x4001C40")]
			[FieldOffset(Offset = "0x84")]
			private bool _placeBuilt;
		}

		// Token: 0x02000488 RID: 1160
		[Token(Token = "0x2000488")]
		[Serializable]
		public class TreeStructurePlaceOperation : PlayerStructurePlaceAction.IPlaceOperation
		{
			// Token: 0x1700041D RID: 1053
			// (get) Token: 0x06001E11 RID: 7697 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001E12 RID: 7698 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700041D")]
			public StructureCraftingNode PreviewStructureNode
			{
				[Token(Token = "0x6001E11")]
				[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001E12")]
				[Address(RVA = "0x6F1D10", Offset = "0x6F0310", VA = "0x1806F1D10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700041E RID: 1054
			// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001E14 RID: 7700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700041E")]
			public StructureRecipe Recipe
			{
				[Token(Token = "0x6001E13")]
				[Address(RVA = "0x6306D0", Offset = "0x62ECD0", VA = "0x1806306D0", Slot = "4")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001E14")]
				[Address(RVA = "0x73EE10", Offset = "0x73D410", VA = "0x18073EE10")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700041F RID: 1055
			// (get) Token: 0x06001E15 RID: 7701 RVA: 0x00008868 File Offset: 0x00006A68
			// (set) Token: 0x06001E16 RID: 7702 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700041F")]
			public bool HasValidPlacementTarget
			{
				[Token(Token = "0x6001E15")]
				[Address(RVA = "0x9ABDB0", Offset = "0x9AA3B0", VA = "0x1809ABDB0", Slot = "5")]
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6001E16")]
				[Address(RVA = "0x2586730", Offset = "0x2584D30", VA = "0x182586730")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000420 RID: 1056
			// (get) Token: 0x06001E17 RID: 7703 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06001E18 RID: 7704 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000420")]
			public Transform TargetTree
			{
				[Token(Token = "0x6001E17")]
				[Address(RVA = "0x8DD0A0", Offset = "0x8DB6A0", VA = "0x1808DD0A0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6001E18")]
				[Address(RVA = "0x8DD0B0", Offset = "0x8DB6B0", VA = "0x1808DD0B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06001E19 RID: 7705 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E19")]
			[Address(RVA = "0x32EA2B0", Offset = "0x32E88B0", VA = "0x1832EA2B0")]
			public void Init(InputAction rotateAction, InputAction primaryAction, InputAction secondaryAction, Action onPlace, Action onCancel)
			{
			}

			// Token: 0x06001E1A RID: 7706 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E1A")]
			[Address(RVA = "0x32EA780", Offset = "0x32E8D80", VA = "0x1832EA780", Slot = "6")]
			private void Begin(StructureRecipe recipe, bool placeBuilt)
			{
			}

			// Token: 0x06001E1B RID: 7707 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E1B")]
			[Address(RVA = "0x32EAB20", Offset = "0x32E9120", VA = "0x1832EAB20", Slot = "7")]
			private void Stop()
			{
			}

			// Token: 0x06001E1C RID: 7708 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E1C")]
			[Address(RVA = "0x32EACF0", Offset = "0x32E92F0", VA = "0x1832EACF0", Slot = "8")]
			private void OnPlace(StructureCraftingSystem structureCraftingSystem)
			{
			}

			// Token: 0x06001E1D RID: 7709 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E1D")]
			[Address(RVA = "0x32EB230", Offset = "0x32E9830", VA = "0x1832EB230", Slot = "9")]
			private void Update()
			{
			}

			// Token: 0x06001E1E RID: 7710 RVA: 0x00008880 File Offset: 0x00006A80
			[Token(Token = "0x6001E1E")]
			[Address(RVA = "0x32EBC30", Offset = "0x32EA230", VA = "0x1832EBC30")]
			private bool TryGetHitPoint(out Vector3 point, out Vector3 normal)
			{
				return default(bool);
			}

			// Token: 0x06001E1F RID: 7711 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E1F")]
			[Address(RVA = "0x32EC240", Offset = "0x32EA840", VA = "0x1832EC240")]
			private void ProcessRotationAndAlignment(Vector3 actorPosition, Vector3 hitNormal)
			{
			}

			// Token: 0x06001E20 RID: 7712 RVA: 0x00008898 File Offset: 0x00006A98
			[Token(Token = "0x6001E20")]
			[Address(RVA = "0x32EC7D0", Offset = "0x32EADD0", VA = "0x1832EC7D0")]
			private float CalcMaxPlaceDistance()
			{
				return 0f;
			}

			// Token: 0x06001E21 RID: 7713 RVA: 0x000088B0 File Offset: 0x00006AB0
			[Token(Token = "0x6001E21")]
			[Address(RVA = "0x32EC800", Offset = "0x32EAE00", VA = "0x1832EC800")]
			private bool CheckIfPlacementSpaceIsValid(StructureCraftingNode previewNode, out Transform closestTreeTr)
			{
				return default(bool);
			}

			// Token: 0x06001E22 RID: 7714 RVA: 0x000088C8 File Offset: 0x00006AC8
			[Token(Token = "0x6001E22")]
			[Address(RVA = "0x32ECF90", Offset = "0x32EB590", VA = "0x1832ECF90")]
			private bool TryFindTree(int hitCount, ref float closestTreeDist, ref Transform closestTreeTr)
			{
				return default(bool);
			}

			// Token: 0x06001E23 RID: 7715 RVA: 0x000088E0 File Offset: 0x00006AE0
			[Token(Token = "0x6001E23")]
			[Address(RVA = "0x32ED430", Offset = "0x32EBA30", VA = "0x1832ED430")]
			private bool TrySnapToTree(Transform closestTreeTr, Vector3 actorPosition)
			{
				return default(bool);
			}

			// Token: 0x06001E24 RID: 7716 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E24")]
			[Address(RVA = "0x1D11630", Offset = "0x1D0FC30", VA = "0x181D11630")]
			private void CancelPlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001E25 RID: 7717 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E25")]
			[Address(RVA = "0x32E9AE0", Offset = "0x32E80E0", VA = "0x1832E9AE0")]
			private void ValidatePlacement(InputAction.CallbackContext ctx)
			{
			}

			// Token: 0x06001E26 RID: 7718 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E26")]
			[Address(RVA = "0x32ED940", Offset = "0x32EBF40", VA = "0x1832ED940")]
			private void InitPreviewStructure(StructureRecipe structureRecipe)
			{
			}

			// Token: 0x06001E27 RID: 7719 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E27")]
			[Address(RVA = "0x32EDC40", Offset = "0x32EC240", VA = "0x1832EDC40")]
			private void CleanUpPreviewStructrure()
			{
			}

			// Token: 0x06001E28 RID: 7720 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E28")]
			[Address(RVA = "0x32EDDD0", Offset = "0x32EC3D0", VA = "0x1832EDDD0")]
			public void CleanUp()
			{
			}

			// Token: 0x06001E29 RID: 7721 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6001E29")]
			[Address(RVA = "0x32EDF00", Offset = "0x32EC500", VA = "0x1832EDF00")]
			public TreeStructurePlaceOperation()
			{
			}

			// Token: 0x04001C44 RID: 7236
			[Token(Token = "0x4001C44")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			[Min(3f)]
			private float _maxPlacementRange;

			// Token: 0x04001C45 RID: 7237
			[Token(Token = "0x4001C45")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private float _rotationSpeed;

			// Token: 0x04001C46 RID: 7238
			[Token(Token = "0x4001C46")]
			[FieldOffset(Offset = "0x18")]
			[SerializeField]
			private LayerMask _placementSurfaceLayerMask;

			// Token: 0x04001C47 RID: 7239
			[Token(Token = "0x4001C47")]
			[FieldOffset(Offset = "0x1C")]
			[SerializeField]
			private LayerMask _invalidOverlapsLayerMask;

			// Token: 0x04001C48 RID: 7240
			[Token(Token = "0x4001C48")]
			[FieldOffset(Offset = "0x20")]
			[SerializeField]
			[Range(0f, 1f)]
			private float _placementBoundsThreshold;

			// Token: 0x04001C49 RID: 7241
			[Token(Token = "0x4001C49")]
			[FieldOffset(Offset = "0x28")]
			private InputAction _rotateAction;

			// Token: 0x04001C4A RID: 7242
			[Token(Token = "0x4001C4A")]
			[FieldOffset(Offset = "0x30")]
			private InputAction _primaryAction;

			// Token: 0x04001C4B RID: 7243
			[Token(Token = "0x4001C4B")]
			[FieldOffset(Offset = "0x38")]
			private InputAction _secondaryAction;

			// Token: 0x04001C4C RID: 7244
			[Token(Token = "0x4001C4C")]
			[FieldOffset(Offset = "0x40")]
			private Action _onPlaced;

			// Token: 0x04001C4D RID: 7245
			[Token(Token = "0x4001C4D")]
			[FieldOffset(Offset = "0x48")]
			private Action _onCancelled;

			// Token: 0x04001C4E RID: 7246
			[Token(Token = "0x4001C4E")]
			[FieldOffset(Offset = "0x50")]
			private Transform _placementTargetTransform;

			// Token: 0x04001C4F RID: 7247
			[Token(Token = "0x4001C4F")]
			[FieldOffset(Offset = "0x58")]
			private BoxCollider _placementTargetCollider;

			// Token: 0x04001C50 RID: 7248
			[Token(Token = "0x4001C50")]
			[FieldOffset(Offset = "0x60")]
			private float _structureRotation;

			// Token: 0x04001C51 RID: 7249
			[Token(Token = "0x4001C51")]
			[FieldOffset(Offset = "0x68")]
			private readonly Collider[] _overlappingPlacementBounds;
		}
	}
}
