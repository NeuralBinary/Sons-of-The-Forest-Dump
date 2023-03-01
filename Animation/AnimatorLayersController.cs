using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Animation
{
	// Token: 0x020008A0 RID: 2208
	[Token(Token = "0x20008A0")]
	public class AnimatorLayersController : MonoBehaviour
	{
		// Token: 0x06003B94 RID: 15252 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B94")]
		[Address(RVA = "0x2EF8470", Offset = "0x2EF7470", VA = "0x182EF8470")]
		public void RegisterLayerBehaviourActivators(ILayerBehaviourActivator[] activators)
		{
		}

		// Token: 0x06003B95 RID: 15253 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B95")]
		[Address(RVA = "0x2EF8A10", Offset = "0x2EF7A10", VA = "0x182EF8A10")]
		public void RegisterLayerBehaviourDisablers(ILayerBehaviourActivator[] disablers)
		{
		}

		// Token: 0x06003B96 RID: 15254 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B96")]
		[Address(RVA = "0x2EF90D0", Offset = "0x2EF80D0", VA = "0x182EF90D0")]
		public void UnregisterLayerBehaviourActivators(ILayerBehaviourActivator[] activators)
		{
		}

		// Token: 0x06003B97 RID: 15255 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B97")]
		[Address(RVA = "0x2EF9480", Offset = "0x2EF8480", VA = "0x182EF9480")]
		public void UnregisterLayerBehaviourDisablers(ILayerBehaviourActivator[] disablers)
		{
		}

		// Token: 0x06003B98 RID: 15256 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B98")]
		[Address(RVA = "0x2EF81D0", Offset = "0x2EF71D0", VA = "0x182EF81D0")]
		public void RegisterLayerBehaviourActivator(ILayerBehaviourActivator activator)
		{
		}

		// Token: 0x06003B99 RID: 15257 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B99")]
		[Address(RVA = "0x2EF8F20", Offset = "0x2EF7F20", VA = "0x182EF8F20")]
		public void UnregisterLayerBehaviourActivator(ILayerBehaviourActivator activator)
		{
		}

		// Token: 0x06003B9A RID: 15258 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9A")]
		[Address(RVA = "0x2EF8770", Offset = "0x2EF7770", VA = "0x182EF8770")]
		public void RegisterLayerBehaviourDisabler(ILayerBehaviourActivator disabler)
		{
		}

		// Token: 0x06003B9B RID: 15259 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9B")]
		[Address(RVA = "0x2EF92D0", Offset = "0x2EF82D0", VA = "0x182EF92D0")]
		public void UnregisterLayerBehaviourDisabler(ILayerBehaviourActivator disabler)
		{
		}

		// Token: 0x06003B9C RID: 15260 RVA: 0x000114C0 File Offset: 0x0000F6C0
		[Token(Token = "0x6003B9C")]
		[Address(RVA = "0x2EF8000", Offset = "0x2EF7000", VA = "0x182EF8000")]
		public bool HasLayerActivator(int layer)
		{
			return default(bool);
		}

		// Token: 0x06003B9D RID: 15261 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003B9D")]
		[Address(RVA = "0x2EF7F40", Offset = "0x2EF6F40", VA = "0x182EF7F40")]
		public string GetActivatorLog()
		{
			return null;
		}

		// Token: 0x06003B9E RID: 15262 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9E")]
		[Address(RVA = "0x2EF7E40", Offset = "0x2EF6E40", VA = "0x182EF7E40")]
		private void DumpActivatorsToLog()
		{
		}

		// Token: 0x06003B9F RID: 15263 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003B9F")]
		[Address(RVA = "0x2EF8D10", Offset = "0x2EF7D10", VA = "0x182EF8D10")]
		public void RegisterLayerBehaviour(int layer, AnimatorLayersController.LayerBehaviours behaviour, Action onActivated, Action onDeactivated)
		{
		}

		// Token: 0x06003BA0 RID: 15264 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA0")]
		[Address(RVA = "0x2EF81C0", Offset = "0x2EF71C0", VA = "0x182EF81C0")]
		private void OnEnable()
		{
		}

		// Token: 0x06003BA1 RID: 15265 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA1")]
		[Address(RVA = "0x2EF8180", Offset = "0x2EF7180", VA = "0x182EF8180")]
		private void OnDisable()
		{
		}

		// Token: 0x06003BA2 RID: 15266 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA2")]
		[Address(RVA = "0x683D30", Offset = "0x682D30", VA = "0x180683D30")]
		private void Update()
		{
		}

		// Token: 0x06003BA3 RID: 15267 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA3")]
		[Address(RVA = "0x2EF80E0", Offset = "0x2EF70E0", VA = "0x182EF80E0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06003BA4 RID: 15268 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA4")]
		[Address(RVA = "0x2EF8EA0", Offset = "0x2EF7EA0", VA = "0x182EF8EA0")]
		private void StartExecutionCoroutine()
		{
		}

		// Token: 0x06003BA5 RID: 15269 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA5")]
		[Address(RVA = "0x2EF8180", Offset = "0x2EF7180", VA = "0x182EF8180")]
		private void StopExecutionCoroutine()
		{
		}

		// Token: 0x06003BA6 RID: 15270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003BA6")]
		[Address(RVA = "0x2EF8070", Offset = "0x2EF7070", VA = "0x182EF8070")]
		private IEnumerator LateCoroutineUpdate()
		{
			return null;
		}

		// Token: 0x06003BA7 RID: 15271 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003BA7")]
		[Address(RVA = "0x2EF9680", Offset = "0x2EF8680", VA = "0x182EF9680")]
		public AnimatorLayersController()
		{
		}

		// Token: 0x04003FE4 RID: 16356
		[Token(Token = "0x4003FE4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private bool _verboseActivatorRegistrations;

		// Token: 0x04003FE5 RID: 16357
		[Token(Token = "0x4003FE5")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Animator _animator;

		// Token: 0x04003FE6 RID: 16358
		[Token(Token = "0x4003FE6")]
		[FieldOffset(Offset = "0x30")]
		private Dictionary<int, AnimatorLayersController.LayerData> _layersData;

		// Token: 0x04003FE7 RID: 16359
		[Token(Token = "0x4003FE7")]
		[FieldOffset(Offset = "0x38")]
		private Coroutine _executionCoroutine;

		// Token: 0x04003FE8 RID: 16360
		[Token(Token = "0x4003FE8")]
		[FieldOffset(Offset = "0x40")]
		private bool _shouldRestartCoroutine;

		// Token: 0x020008A1 RID: 2209
		[Token(Token = "0x20008A1")]
		public enum LayerBehaviours
		{
			// Token: 0x04003FEA RID: 16362
			[Token(Token = "0x4003FEA")]
			Enable,
			// Token: 0x04003FEB RID: 16363
			[Token(Token = "0x4003FEB")]
			Disable
		}

		// Token: 0x020008A2 RID: 2210
		[Token(Token = "0x20008A2")]
		private class LayerData
		{
			// Token: 0x17000745 RID: 1861
			// (get) Token: 0x06003BA8 RID: 15272 RVA: 0x000114D8 File Offset: 0x0000F6D8
			// (set) Token: 0x06003BA9 RID: 15273 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000745")]
			public int Layer
			{
				[Token(Token = "0x6003BA8")]
				[Address(RVA = "0x55E9A0", Offset = "0x55D9A0", VA = "0x18055E9A0")]
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[Token(Token = "0x6003BA9")]
				[Address(RVA = "0x6A2410", Offset = "0x6A1410", VA = "0x1806A2410")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x17000746 RID: 1862
			// (get) Token: 0x06003BAA RID: 15274 RVA: 0x000114F0 File Offset: 0x0000F6F0
			// (set) Token: 0x06003BAB RID: 15275 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000746")]
			private AnimatorLayersController.LayerBehaviours Behaviour
			{
				[Token(Token = "0x6003BAA")]
				[Address(RVA = "0x5D9490", Offset = "0x5D8490", VA = "0x1805D9490")]
				[CompilerGenerated]
				get
				{
					return AnimatorLayersController.LayerBehaviours.Enable;
				}
				[Token(Token = "0x6003BAB")]
				[Address(RVA = "0x5D9550", Offset = "0x5D8550", VA = "0x1805D9550")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000747 RID: 1863
			// (get) Token: 0x06003BAC RID: 15276 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003BAD RID: 15277 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000747")]
			private Action OnActivated
			{
				[Token(Token = "0x6003BAC")]
				[Address(RVA = "0x57B1D0", Offset = "0x57A1D0", VA = "0x18057B1D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003BAD")]
				[Address(RVA = "0x5A85C0", Offset = "0x5A75C0", VA = "0x1805A85C0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000748 RID: 1864
			// (get) Token: 0x06003BAE RID: 15278 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003BAF RID: 15279 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000748")]
			private Action OnDeactivated
			{
				[Token(Token = "0x6003BAE")]
				[Address(RVA = "0x541200", Offset = "0x540200", VA = "0x180541200")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003BAF")]
				[Address(RVA = "0x541240", Offset = "0x540240", VA = "0x180541240")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x17000749 RID: 1865
			// (get) Token: 0x06003BB0 RID: 15280 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003BB1 RID: 15281 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000749")]
			private List<ILayerBehaviourActivator> Activators
			{
				[Token(Token = "0x6003BB0")]
				[Address(RVA = "0x541230", Offset = "0x540230", VA = "0x180541230")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003BB1")]
				[Address(RVA = "0x541270", Offset = "0x540270", VA = "0x180541270")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074A RID: 1866
			// (get) Token: 0x06003BB2 RID: 15282 RVA: 0x00002050 File Offset: 0x00000250
			// (set) Token: 0x06003BB3 RID: 15283 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074A")]
			private List<ILayerBehaviourActivator> Disablers
			{
				[Token(Token = "0x6003BB2")]
				[Address(RVA = "0x541210", Offset = "0x540210", VA = "0x180541210")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x6003BB3")]
				[Address(RVA = "0x541250", Offset = "0x540250", VA = "0x180541250")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074B RID: 1867
			// (get) Token: 0x06003BB4 RID: 15284 RVA: 0x00011508 File Offset: 0x0000F708
			// (set) Token: 0x06003BB5 RID: 15285 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074B")]
			public float CurrentWeight
			{
				[Token(Token = "0x6003BB4")]
				[Address(RVA = "0x6849A0", Offset = "0x6839A0", VA = "0x1806849A0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6003BB5")]
				[Address(RVA = "0x1D40CF0", Offset = "0x1D3FCF0", VA = "0x181D40CF0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x1700074C RID: 1868
			// (get) Token: 0x06003BB6 RID: 15286 RVA: 0x00011520 File Offset: 0x0000F720
			// (set) Token: 0x06003BB7 RID: 15287 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074C")]
			private float WeightAlpha
			{
				[Token(Token = "0x6003BB6")]
				[Address(RVA = "0x2004010", Offset = "0x2003010", VA = "0x182004010")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6003BB7")]
				[Address(RVA = "0x2874C50", Offset = "0x2873C50", VA = "0x182874C50")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074D RID: 1869
			// (get) Token: 0x06003BB8 RID: 15288 RVA: 0x00011538 File Offset: 0x0000F738
			// (set) Token: 0x06003BB9 RID: 15289 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074D")]
			private float WeightFrom
			{
				[Token(Token = "0x6003BB8")]
				[Address(RVA = "0x6C5560", Offset = "0x6C4560", VA = "0x1806C5560")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6003BB9")]
				[Address(RVA = "0x6C55A0", Offset = "0x6C45A0", VA = "0x1806C55A0")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074E RID: 1870
			// (get) Token: 0x06003BBA RID: 15290 RVA: 0x00011550 File Offset: 0x0000F750
			// (set) Token: 0x06003BBB RID: 15291 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x1700074E")]
			private float WeightTo
			{
				[Token(Token = "0x6003BBA")]
				[Address(RVA = "0x20103A0", Offset = "0x200F3A0", VA = "0x1820103A0")]
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[Token(Token = "0x6003BBB")]
				[Address(RVA = "0x2810610", Offset = "0x280F610", VA = "0x182810610")]
				[CompilerGenerated]
				set
				{
				}
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x06003BBC RID: 15292 RVA: 0x00011568 File Offset: 0x0000F768
			[Token(Token = "0x1700074F")]
			private int ActivatorCount
			{
				[Token(Token = "0x6003BBC")]
				[Address(RVA = "0x2F00BD0", Offset = "0x2EFFBD0", VA = "0x182F00BD0")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x17000750 RID: 1872
			// (get) Token: 0x06003BBD RID: 15293 RVA: 0x00011580 File Offset: 0x0000F780
			[Token(Token = "0x17000750")]
			private int DisablerCount
			{
				[Token(Token = "0x6003BBD")]
				[Address(RVA = "0x2F00C10", Offset = "0x2EFFC10", VA = "0x182F00C10")]
				get
				{
					return default(int);
				}
			}

			// Token: 0x17000751 RID: 1873
			// (get) Token: 0x06003BBE RID: 15294 RVA: 0x00011598 File Offset: 0x0000F798
			// (set) Token: 0x06003BBF RID: 15295 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000751")]
			public AnimatorLayersController.LayerData.States State
			{
				[Token(Token = "0x6003BBE")]
				[Address(RVA = "0x6B72E0", Offset = "0x6B62E0", VA = "0x1806B72E0")]
				[CompilerGenerated]
				get
				{
					return AnimatorLayersController.LayerData.States.Off;
				}
				[Token(Token = "0x6003BBF")]
				[Address(RVA = "0x7D4E80", Offset = "0x7D3E80", VA = "0x1807D4E80")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06003BC0 RID: 15296 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BC0")]
			[Address(RVA = "0x2F00AB0", Offset = "0x2EFFAB0", VA = "0x182F00AB0")]
			public LayerData(int layer, AnimatorLayersController.LayerBehaviours behaviours, Action onActivated, Action onDeactivated)
			{
			}

			// Token: 0x06003BC1 RID: 15297 RVA: 0x000115B0 File Offset: 0x0000F7B0
			[Token(Token = "0x6003BC1")]
			[Address(RVA = "0x2EFFE00", Offset = "0x2EFEE00", VA = "0x182EFFE00")]
			public bool AddActivator(ILayerBehaviourActivator activator)
			{
				return default(bool);
			}

			// Token: 0x06003BC2 RID: 15298 RVA: 0x000115C8 File Offset: 0x0000F7C8
			[Token(Token = "0x6003BC2")]
			[Address(RVA = "0x2F00840", Offset = "0x2EFF840", VA = "0x182F00840")]
			public bool RemoveActivator(ILayerBehaviourActivator activator)
			{
				return default(bool);
			}

			// Token: 0x06003BC3 RID: 15299 RVA: 0x000115E0 File Offset: 0x0000F7E0
			[Token(Token = "0x6003BC3")]
			[Address(RVA = "0x2EFFEF0", Offset = "0x2EFEEF0", VA = "0x182EFFEF0")]
			public bool AddDisabler(ILayerBehaviourActivator disabler)
			{
				return default(bool);
			}

			// Token: 0x06003BC4 RID: 15300 RVA: 0x000115F8 File Offset: 0x0000F7F8
			[Token(Token = "0x6003BC4")]
			[Address(RVA = "0x2F008A0", Offset = "0x2EFF8A0", VA = "0x182F008A0")]
			public bool RemoveDisabler(ILayerBehaviourActivator disabler)
			{
				return default(bool);
			}

			// Token: 0x06003BC5 RID: 15301 RVA: 0x00011610 File Offset: 0x0000F810
			[Token(Token = "0x6003BC5")]
			[Address(RVA = "0x2F00420", Offset = "0x2EFF420", VA = "0x182F00420")]
			public bool RefreshState(Animator animator)
			{
				return default(bool);
			}

			// Token: 0x06003BC6 RID: 15302 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BC6")]
			[Address(RVA = "0x1122520", Offset = "0x1121520", VA = "0x181122520")]
			private void Activated()
			{
			}

			// Token: 0x06003BC7 RID: 15303 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BC7")]
			[Address(RVA = "0x23B3190", Offset = "0x23B2190", VA = "0x1823B3190")]
			private void Deactivated()
			{
			}

			// Token: 0x06003BC8 RID: 15304 RVA: 0x00011628 File Offset: 0x0000F828
			[Token(Token = "0x6003BC8")]
			[Address(RVA = "0x2F00000", Offset = "0x2EFF000", VA = "0x182F00000")]
			private AnimatorLayersController.LayerData.States CalcState(bool hasValidActivator, bool hasValidDisabler, bool reachedTargetWeight)
			{
				return AnimatorLayersController.LayerData.States.Off;
			}

			// Token: 0x06003BC9 RID: 15305 RVA: 0x00011640 File Offset: 0x0000F840
			[Token(Token = "0x6003BC9")]
			[Address(RVA = "0x2F00360", Offset = "0x2EFF360", VA = "0x182F00360")]
			private bool HasValidDisabler()
			{
				return default(bool);
			}

			// Token: 0x06003BCA RID: 15306 RVA: 0x00011658 File Offset: 0x0000F858
			[Token(Token = "0x6003BCA")]
			[Address(RVA = "0x2F002A0", Offset = "0x2EFF2A0", VA = "0x182F002A0")]
			private bool HasValidActivator()
			{
				return default(bool);
			}

			// Token: 0x06003BCB RID: 15307 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BCB")]
			[Address(RVA = "0x2F00A70", Offset = "0x2EFFA70", VA = "0x182F00A70")]
			public void UpdateWeightAlpha()
			{
			}

			// Token: 0x06003BCC RID: 15308 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BCC")]
			[Address(RVA = "0x2F00A20", Offset = "0x2EFFA20", VA = "0x182F00A20")]
			public void UpdateCurrentWeight()
			{
			}

			// Token: 0x06003BCD RID: 15309 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BCD")]
			[Address(RVA = "0x2EFFFE0", Offset = "0x2EFEFE0", VA = "0x182EFFFE0")]
			public void ApplyTo(Animator animator)
			{
			}

			// Token: 0x06003BCE RID: 15310 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6003BCE")]
			[Address(RVA = "0x2F00040", Offset = "0x2EFF040", VA = "0x182F00040")]
			public string GetActivatorLog()
			{
				return null;
			}

			// Token: 0x06003BCF RID: 15311 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BCF")]
			[Address(RVA = "0x2F00900", Offset = "0x2EFF900", VA = "0x182F00900")]
			[CompilerGenerated]
			private void <RefreshState>g__CalcWeightAlphaFromAnimator|53_0(Animator animator1)
			{
			}

			// Token: 0x06003BD0 RID: 15312 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003BD0")]
			[Address(RVA = "0x2F00980", Offset = "0x2EFF980", VA = "0x182F00980")]
			[CompilerGenerated]
			private void <RefreshState>g__LegacyLayerControlSmoothOutBlend|53_1(Animator animator1)
			{
			}

			// Token: 0x020008A3 RID: 2211
			[Token(Token = "0x20008A3")]
			public enum States
			{
				// Token: 0x04003FF8 RID: 16376
				[Token(Token = "0x4003FF8")]
				Off,
				// Token: 0x04003FF9 RID: 16377
				[Token(Token = "0x4003FF9")]
				SmoothingIn,
				// Token: 0x04003FFA RID: 16378
				[Token(Token = "0x4003FFA")]
				SmoothingOut,
				// Token: 0x04003FFB RID: 16379
				[Token(Token = "0x4003FFB")]
				Maintaining
			}
		}
	}
}
