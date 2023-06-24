using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x02000912 RID: 2322
	[Token(Token = "0x2000912")]
	public class AnimatorLayersController : MonoBehaviour
	{
		// Token: 0x060042C5 RID: 17093 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C5")]
		[Address(RVA = "0x363BF00", Offset = "0x363A500", VA = "0x18363BF00")]
		public void RegisterLayerBehaviourActivators(ILayerBehaviourActivator[] activators)
		{
		}

		// Token: 0x060042C6 RID: 17094 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C6")]
		[Address(RVA = "0x363C270", Offset = "0x363A870", VA = "0x18363C270")]
		public void RegisterLayerBehaviourDisablers(ILayerBehaviourActivator[] disablers)
		{
		}

		// Token: 0x060042C7 RID: 17095 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C7")]
		[Address(RVA = "0x363C5E0", Offset = "0x363ABE0", VA = "0x18363C5E0")]
		public void UnregisterLayerBehaviourActivators(ILayerBehaviourActivator[] activators)
		{
		}

		// Token: 0x060042C8 RID: 17096 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C8")]
		[Address(RVA = "0x363C930", Offset = "0x363AF30", VA = "0x18363C930")]
		public void UnregisterLayerBehaviourDisablers(ILayerBehaviourActivator[] disablers)
		{
		}

		// Token: 0x060042C9 RID: 17097 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042C9")]
		[Address(RVA = "0x363CC80", Offset = "0x363B280", VA = "0x18363CC80")]
		public void RegisterLayerBehaviourActivator(ILayerBehaviourActivator activator)
		{
		}

		// Token: 0x060042CA RID: 17098 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CA")]
		[Address(RVA = "0x363CEC0", Offset = "0x363B4C0", VA = "0x18363CEC0")]
		public void UnregisterLayerBehaviourActivator(ILayerBehaviourActivator activator)
		{
		}

		// Token: 0x060042CB RID: 17099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CB")]
		[Address(RVA = "0x363D070", Offset = "0x363B670", VA = "0x18363D070")]
		public void RegisterLayerBehaviourDisabler(ILayerBehaviourActivator disabler)
		{
		}

		// Token: 0x060042CC RID: 17100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CC")]
		[Address(RVA = "0x363D2B0", Offset = "0x363B8B0", VA = "0x18363D2B0")]
		public void UnregisterLayerBehaviourDisabler(ILayerBehaviourActivator disabler)
		{
		}

		// Token: 0x060042CD RID: 17101 RVA: 0x00014358 File Offset: 0x00012558
		[Token(Token = "0x60042CD")]
		[Address(RVA = "0x363D460", Offset = "0x363BA60", VA = "0x18363D460")]
		public bool HasLayerActivator(int layer)
		{
			return default(bool);
		}

		// Token: 0x060042CE RID: 17102 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042CE")]
		[Address(RVA = "0x363D4D0", Offset = "0x363BAD0", VA = "0x18363D4D0")]
		public string GetActivatorLog()
		{
			return null;
		}

		// Token: 0x060042CF RID: 17103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042CF")]
		[Address(RVA = "0x363D630", Offset = "0x363BC30", VA = "0x18363D630")]
		private void DumpActivatorsToLog()
		{
		}

		// Token: 0x060042D0 RID: 17104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D0")]
		[Address(RVA = "0x363D690", Offset = "0x363BC90", VA = "0x18363D690")]
		public void RegisterLayerBehaviour(int layer, AnimatorLayersController.LayerBehaviours behaviour, Action onActivated, Action onDeactivated)
		{
		}

		// Token: 0x060042D1 RID: 17105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D1")]
		[Address(RVA = "0x363D790", Offset = "0x363BD90", VA = "0x18363D790")]
		private void OnEnable()
		{
		}

		// Token: 0x060042D2 RID: 17106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D2")]
		[Address(RVA = "0x363D7A0", Offset = "0x363BDA0", VA = "0x18363D7A0")]
		private void OnDisable()
		{
		}

		// Token: 0x060042D3 RID: 17107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D3")]
		[Address(RVA = "0x71EE50", Offset = "0x71D450", VA = "0x18071EE50")]
		private void Update()
		{
		}

		// Token: 0x060042D4 RID: 17108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D4")]
		[Address(RVA = "0x363D7B0", Offset = "0x363BDB0", VA = "0x18363D7B0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060042D5 RID: 17109 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D5")]
		[Address(RVA = "0x363D830", Offset = "0x363BE30", VA = "0x18363D830")]
		private void StartExecutionCoroutine()
		{
		}

		// Token: 0x060042D6 RID: 17110 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D6")]
		[Address(RVA = "0x3557280", Offset = "0x3555880", VA = "0x183557280")]
		private void StopExecutionCoroutine()
		{
		}

		// Token: 0x060042D7 RID: 17111 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042D7")]
		[Address(RVA = "0x363D940", Offset = "0x363BF40", VA = "0x18363D940")]
		private IEnumerator LateCoroutineUpdate()
		{
			return null;
		}

		// Token: 0x060042D8 RID: 17112 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60042D8")]
		[Address(RVA = "0x363D9D0", Offset = "0x363BFD0", VA = "0x18363D9D0")]
		public AnimatorLayersController()
		{
		}

		// Token: 0x04004610 RID: 17936
		[Token(Token = "0x4004610")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _verboseActivatorRegistrations;

		// Token: 0x04004611 RID: 17937
		[Token(Token = "0x4004611")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04004612 RID: 17938
		[Token(Token = "0x4004612")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, AnimatorLayersController.LayerData> _layersData;

		// Token: 0x04004613 RID: 17939
		[Token(Token = "0x4004613")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine _executionCoroutine;

		// Token: 0x04004614 RID: 17940
		[Token(Token = "0x4004614")]
		[FieldOffset(Offset = "0x40")]
		private bool _shouldRestartCoroutine;

		// Token: 0x02000913 RID: 2323
		[Token(Token = "0x2000913")]
		public enum LayerBehaviours
		{
			// Token: 0x04004616 RID: 17942
			[Token(Token = "0x4004616")]
			Enable,
			// Token: 0x04004617 RID: 17943
			[Token(Token = "0x4004617")]
			Disable
		}

		// Token: 0x02000914 RID: 2324
		[Token(Token = "0x2000914")]
		private class LayerData
		{
			// Token: 0x1700086A RID: 2154
			// (get) Token: 0x060042D9 RID: 17113 RVA: 0x00014370 File Offset: 0x00012570
			// (set) Token: 0x060042DA RID: 17114 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700086A")]
			public int Layer
			{
				[Token(Token = "0x60042D9")]
				[Address(RVA = "0x5DC420", Offset = "0x5DAA20", VA = "0x1805DC420")]
				[CompilerGenerated]
				get
				{
					return 0;
				}
				[Token(Token = "0x60042DA")]
				[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700086B RID: 2155
			// (get) Token: 0x060042DB RID: 17115 RVA: 0x00014388 File Offset: 0x00012588
			// (set) Token: 0x060042DC RID: 17116 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700086B")]
			private AnimatorLayersController.LayerBehaviours Behaviour
			{
				[Token(Token = "0x60042DB")]
				[Address(RVA = "0x66F500", Offset = "0x66DB00", VA = "0x18066F500")]
				[CompilerGenerated]
				get
				{
					return AnimatorLayersController.LayerBehaviours.Enable;
				}
				[Token(Token = "0x60042DC")]
				[Address(RVA = "0x66F510", Offset = "0x66DB10", VA = "0x18066F510")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700086C RID: 2156
			// (get) Token: 0x060042DD RID: 17117 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060042DE RID: 17118 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700086C")]
			private Action OnActivated
			{
				[Token(Token = "0x60042DD")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60042DE")]
				[Address(RVA = "0x635680", Offset = "0x633C80", VA = "0x180635680")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700086D RID: 2157
			// (get) Token: 0x060042DF RID: 17119 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060042E0 RID: 17120 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700086D")]
			private Action OnDeactivated
			{
				[Token(Token = "0x60042DF")]
				[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60042E0")]
				[Address(RVA = "0x5B2E10", Offset = "0x5B1410", VA = "0x1805B2E10")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700086E RID: 2158
			// (get) Token: 0x060042E1 RID: 17121 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060042E2 RID: 17122 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700086E")]
			private List<ILayerBehaviourActivator> Activators
			{
				[Token(Token = "0x60042E1")]
				[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60042E2")]
				[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700086F RID: 2159
			// (get) Token: 0x060042E3 RID: 17123 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x060042E4 RID: 17124 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700086F")]
			private List<ILayerBehaviourActivator> Disablers
			{
				[Token(Token = "0x60042E3")]
				[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x60042E4")]
				[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000870 RID: 2160
			// (get) Token: 0x060042E5 RID: 17125 RVA: 0x000143A0 File Offset: 0x000125A0
			// (set) Token: 0x060042E6 RID: 17126 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000870")]
			public float CurrentWeight
			{
				[Token(Token = "0x60042E5")]
				[Address(RVA = "0x71D320", Offset = "0x71B920", VA = "0x18071D320")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60042E6")]
				[Address(RVA = "0x207C3C0", Offset = "0x207A9C0", VA = "0x18207C3C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000871 RID: 2161
			// (get) Token: 0x060042E7 RID: 17127 RVA: 0x000143B8 File Offset: 0x000125B8
			// (set) Token: 0x060042E8 RID: 17128 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000871")]
			private float WeightAlpha
			{
				[Token(Token = "0x60042E7")]
				[Address(RVA = "0x23A5B70", Offset = "0x23A4170", VA = "0x1823A5B70")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60042E8")]
				[Address(RVA = "0x2D63590", Offset = "0x2D61B90", VA = "0x182D63590")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000872 RID: 2162
			// (get) Token: 0x060042E9 RID: 17129 RVA: 0x000143D0 File Offset: 0x000125D0
			// (set) Token: 0x060042EA RID: 17130 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000872")]
			private float WeightFrom
			{
				[Token(Token = "0x60042E9")]
				[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60042EA")]
				[Address(RVA = "0x781580", Offset = "0x77FB80", VA = "0x180781580")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000873 RID: 2163
			// (get) Token: 0x060042EB RID: 17131 RVA: 0x000143E8 File Offset: 0x000125E8
			// (set) Token: 0x060042EC RID: 17132 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000873")]
			private float WeightTo
			{
				[Token(Token = "0x60042EB")]
				[Address(RVA = "0x23B72F0", Offset = "0x23B58F0", VA = "0x1823B72F0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x60042EC")]
				[Address(RVA = "0x2D54950", Offset = "0x2D52F50", VA = "0x182D54950")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000874 RID: 2164
			// (get) Token: 0x060042ED RID: 17133 RVA: 0x00014400 File Offset: 0x00012600
			[Token(Token = "0x17000874")]
			private int ActivatorCount
			{
				[Token(Token = "0x60042ED")]
				[Address(RVA = "0x363DAB0", Offset = "0x363C0B0", VA = "0x18363DAB0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000875 RID: 2165
			// (get) Token: 0x060042EE RID: 17134 RVA: 0x00014418 File Offset: 0x00012618
			[Token(Token = "0x17000875")]
			private int DisablerCount
			{
				[Token(Token = "0x60042EE")]
				[Address(RVA = "0x363DAF0", Offset = "0x363C0F0", VA = "0x18363DAF0")]
				get
				{
					return 0;
				}
			}

			// Token: 0x17000876 RID: 2166
			// (get) Token: 0x060042EF RID: 17135 RVA: 0x00014430 File Offset: 0x00012630
			// (set) Token: 0x060042F0 RID: 17136 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000876")]
			public AnimatorLayersController.LayerData.States State
			{
				[Token(Token = "0x60042EF")]
				[Address(RVA = "0x784B40", Offset = "0x783140", VA = "0x180784B40")]
				[CompilerGenerated]
				get
				{
					return AnimatorLayersController.LayerData.States.Off;
				}
				[Token(Token = "0x60042F0")]
				[Address(RVA = "0x8F80C0", Offset = "0x8F66C0", VA = "0x1808F80C0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x060042F1 RID: 17137 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042F1")]
			[Address(RVA = "0x363DB30", Offset = "0x363C130", VA = "0x18363DB30")]
			public LayerData(int layer, AnimatorLayersController.LayerBehaviours behaviours, Action onActivated, Action onDeactivated)
			{
			}

			// Token: 0x060042F2 RID: 17138 RVA: 0x00014448 File Offset: 0x00012648
			[Token(Token = "0x60042F2")]
			[Address(RVA = "0x363DD50", Offset = "0x363C350", VA = "0x18363DD50")]
			public bool AddActivator(ILayerBehaviourActivator activator)
			{
				return default(bool);
			}

			// Token: 0x060042F3 RID: 17139 RVA: 0x00014460 File Offset: 0x00012660
			[Token(Token = "0x60042F3")]
			[Address(RVA = "0x363DDD0", Offset = "0x363C3D0", VA = "0x18363DDD0")]
			public bool RemoveActivator(ILayerBehaviourActivator activator)
			{
				return default(bool);
			}

			// Token: 0x060042F4 RID: 17140 RVA: 0x00014478 File Offset: 0x00012678
			[Token(Token = "0x60042F4")]
			[Address(RVA = "0x363DE30", Offset = "0x363C430", VA = "0x18363DE30")]
			public bool AddDisabler(ILayerBehaviourActivator disabler)
			{
				return default(bool);
			}

			// Token: 0x060042F5 RID: 17141 RVA: 0x00014490 File Offset: 0x00012690
			[Token(Token = "0x60042F5")]
			[Address(RVA = "0x363DEB0", Offset = "0x363C4B0", VA = "0x18363DEB0")]
			public bool RemoveDisabler(ILayerBehaviourActivator disabler)
			{
				return default(bool);
			}

			// Token: 0x060042F6 RID: 17142 RVA: 0x000144A8 File Offset: 0x000126A8
			[Token(Token = "0x60042F6")]
			[Address(RVA = "0x363DF10", Offset = "0x363C510", VA = "0x18363DF10")]
			public bool RefreshState(Animator animator)
			{
				return default(bool);
			}

			// Token: 0x060042F7 RID: 17143 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042F7")]
			[Address(RVA = "0x131BCF0", Offset = "0x131A2F0", VA = "0x18131BCF0")]
			private void Activated()
			{
			}

			// Token: 0x060042F8 RID: 17144 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042F8")]
			[Address(RVA = "0x282D840", Offset = "0x282BE40", VA = "0x18282D840")]
			private void Deactivated()
			{
			}

			// Token: 0x060042F9 RID: 17145 RVA: 0x000144C0 File Offset: 0x000126C0
			[Token(Token = "0x60042F9")]
			[Address(RVA = "0x363E2F0", Offset = "0x363C8F0", VA = "0x18363E2F0")]
			private AnimatorLayersController.LayerData.States CalcState(bool hasValidActivator, bool hasValidDisabler, bool reachedTargetWeight)
			{
				return AnimatorLayersController.LayerData.States.Off;
			}

			// Token: 0x060042FA RID: 17146 RVA: 0x000144D8 File Offset: 0x000126D8
			[Token(Token = "0x60042FA")]
			[Address(RVA = "0x363E330", Offset = "0x363C930", VA = "0x18363E330")]
			private bool HasValidDisabler()
			{
				return default(bool);
			}

			// Token: 0x060042FB RID: 17147 RVA: 0x000144F0 File Offset: 0x000126F0
			[Token(Token = "0x60042FB")]
			[Address(RVA = "0x363E400", Offset = "0x363CA00", VA = "0x18363E400")]
			private bool HasValidActivator()
			{
				return default(bool);
			}

			// Token: 0x060042FC RID: 17148 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042FC")]
			[Address(RVA = "0x363E4D0", Offset = "0x363CAD0", VA = "0x18363E4D0")]
			public void UpdateWeightAlpha()
			{
			}

			// Token: 0x060042FD RID: 17149 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042FD")]
			[Address(RVA = "0x363E540", Offset = "0x363CB40", VA = "0x18363E540")]
			public void UpdateCurrentWeight()
			{
			}

			// Token: 0x060042FE RID: 17150 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60042FE")]
			[Address(RVA = "0x363E590", Offset = "0x363CB90", VA = "0x18363E590")]
			public void ApplyTo(Animator animator)
			{
			}

			// Token: 0x060042FF RID: 17151 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60042FF")]
			[Address(RVA = "0x363E610", Offset = "0x363CC10", VA = "0x18363E610")]
			public string GetActivatorLog()
			{
				return null;
			}

			// Token: 0x06004300 RID: 17152 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004300")]
			[Address(RVA = "0x363E8B0", Offset = "0x363CEB0", VA = "0x18363E8B0")]
			[CompilerGenerated]
			private void <RefreshState>g__CalcWeightAlphaFromAnimator|53_0(Animator animator1)
			{
			}

			// Token: 0x06004301 RID: 17153 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6004301")]
			[Address(RVA = "0x363E970", Offset = "0x363CF70", VA = "0x18363E970")]
			[CompilerGenerated]
			private void <RefreshState>g__LegacyLayerControlSmoothOutBlend|53_1(Animator animator1)
			{
			}

			// Token: 0x02000915 RID: 2325
			[Token(Token = "0x2000915")]
			public enum States
			{
				// Token: 0x04004624 RID: 17956
				[Token(Token = "0x4004624")]
				Off,
				// Token: 0x04004625 RID: 17957
				[Token(Token = "0x4004625")]
				SmoothingIn,
				// Token: 0x04004626 RID: 17958
				[Token(Token = "0x4004626")]
				SmoothingOut,
				// Token: 0x04004627 RID: 17959
				[Token(Token = "0x4004627")]
				Maintaining
			}
		}
	}
}
