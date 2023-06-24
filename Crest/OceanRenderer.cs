using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Rendering.HighDefinition;

namespace Crest
{
	// Token: 0x02000061 RID: 97
	[Token(Token = "0x2000061")]
	[SelectionBase]
	[ExecuteAlways]
	public class OceanRenderer : MonoBehaviour
	{
		// Token: 0x06000222 RID: 546 RVA: 0x00002D48 File Offset: 0x00000F48
		[Token(Token = "0x6000222")]
		[Address(RVA = "0xA03540", Offset = "0xA01B40", VA = "0x180A03540")]
		public bool CheckMaskRenderer(bool renderCrestUnderwater)
		{
			return default(bool);
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000223 RID: 547 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000224 RID: 548 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007E")]
		public Transform Viewpoint
		{
			[Token(Token = "0x6000223")]
			[Address(RVA = "0xA035C0", Offset = "0xA01BC0", VA = "0x180A035C0")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000224")]
			[Address(RVA = "0x5B27E0", Offset = "0x5B0DE0", VA = "0x1805B27E0")]
			set
			{
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000225 RID: 549 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000226 RID: 550 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700007F")]
		public Camera ViewCamera
		{
			[Token(Token = "0x6000225")]
			[Address(RVA = "0xA03770", Offset = "0xA01D70", VA = "0x180A03770")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000226")]
			[Address(RVA = "0x5B2E90", Offset = "0x5B1490", VA = "0x1805B2E90")]
			set
			{
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000227 RID: 551 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000228 RID: 552 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000080")]
		public Transform Root
		{
			[Token(Token = "0x6000227")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000228")]
			[Address(RVA = "0x5B2F00", Offset = "0x5B1500", VA = "0x1805B2F00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000229 RID: 553 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000081")]
		public ITimeProvider TimeProvider
		{
			[Token(Token = "0x6000229")]
			[Address(RVA = "0xA03A00", Offset = "0xA02000", VA = "0x180A03A00")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600022A RID: 554 RVA: 0x00002D60 File Offset: 0x00000F60
		[Token(Token = "0x17000082")]
		public float CurrentTime
		{
			[Token(Token = "0x600022A")]
			[Address(RVA = "0xA03B40", Offset = "0xA02140", VA = "0x180A03B40")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x0600022B RID: 555 RVA: 0x00002D78 File Offset: 0x00000F78
		[Token(Token = "0x17000083")]
		public float DeltaTime
		{
			[Token(Token = "0x600022B")]
			[Address(RVA = "0xA03B90", Offset = "0xA02190", VA = "0x180A03B90")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x0600022C RID: 556 RVA: 0x00002D90 File Offset: 0x00000F90
		[Token(Token = "0x17000084")]
		public float DeltaTimeDynamics
		{
			[Token(Token = "0x600022C")]
			[Address(RVA = "0xA03BF0", Offset = "0xA021F0", VA = "0x180A03BF0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x0600022D RID: 557 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000085")]
		public Material OceanMaterial
		{
			[Token(Token = "0x600022D")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x0600022E RID: 558 RVA: 0x00002DA8 File Offset: 0x00000FA8
		// (set) Token: 0x0600022F RID: 559 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000086")]
		public Vector3 UnderwaterDepthFogDensity
		{
			[Token(Token = "0x600022E")]
			[Address(RVA = "0xA03C50", Offset = "0xA02250", VA = "0x180A03C50")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Token(Token = "0x600022F")]
			[Address(RVA = "0xA03C70", Offset = "0xA02270", VA = "0x180A03C70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000230 RID: 560 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000087")]
		public string LayerName
		{
			[Token(Token = "0x6000230")]
			[Address(RVA = "0x737410", Offset = "0x735A10", VA = "0x180737410")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x06000231 RID: 561 RVA: 0x00002DC0 File Offset: 0x00000FC0
		[Token(Token = "0x17000088")]
		public float Gravity
		{
			[Token(Token = "0x6000231")]
			[Address(RVA = "0xA03C80", Offset = "0xA02280", VA = "0x180A03C80")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00002DD8 File Offset: 0x00000FD8
		[Token(Token = "0x17000089")]
		public float MinTexelsPerWave
		{
			[Token(Token = "0x6000232")]
			[Address(RVA = "0x7282C0", Offset = "0x7268C0", VA = "0x1807282C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x06000233 RID: 563 RVA: 0x00002DF0 File Offset: 0x00000FF0
		[Token(Token = "0x1700008A")]
		public int LodDataResolution
		{
			[Token(Token = "0x6000233")]
			[Address(RVA = "0xA03D80", Offset = "0xA02380", VA = "0x180A03D80")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000234 RID: 564 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x6000234")]
		[Address(RVA = "0xA03D90", Offset = "0xA02390", VA = "0x180A03D90")]
		public GameObject GetUnderwaterCustomPassObject()
		{
			return null;
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x06000235 RID: 565 RVA: 0x00002E08 File Offset: 0x00001008
		[Token(Token = "0x1700008B")]
		public uint RenderingLayerMask
		{
			[Token(Token = "0x6000235")]
			[Address(RVA = "0x7283B0", Offset = "0x7269B0", VA = "0x1807283B0")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000236 RID: 566 RVA: 0x00002E20 File Offset: 0x00001020
		[Token(Token = "0x1700008C")]
		public bool CreateSeaFloorDepthData
		{
			[Token(Token = "0x6000236")]
			[Address(RVA = "0xA03DA0", Offset = "0xA023A0", VA = "0x180A03DA0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000237 RID: 567 RVA: 0x00002E38 File Offset: 0x00001038
		[Token(Token = "0x1700008D")]
		public bool CreateFoamSim
		{
			[Token(Token = "0x6000237")]
			[Address(RVA = "0xA03DB0", Offset = "0xA023B0", VA = "0x180A03DB0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x06000238 RID: 568 RVA: 0x00002E50 File Offset: 0x00001050
		[Token(Token = "0x1700008E")]
		public bool CreateDynamicWaveSim
		{
			[Token(Token = "0x6000238")]
			[Address(RVA = "0xA03DC0", Offset = "0xA023C0", VA = "0x180A03DC0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x06000239 RID: 569 RVA: 0x00002E68 File Offset: 0x00001068
		[Token(Token = "0x1700008F")]
		public bool CreateFlowSim
		{
			[Token(Token = "0x6000239")]
			[Address(RVA = "0xA03DD0", Offset = "0xA023D0", VA = "0x180A03DD0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x0600023A RID: 570 RVA: 0x00002E80 File Offset: 0x00001080
		[Token(Token = "0x17000090")]
		public bool CreateShadowData
		{
			[Token(Token = "0x600023A")]
			[Address(RVA = "0xA03DE0", Offset = "0xA023E0", VA = "0x180A03DE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x0600023B RID: 571 RVA: 0x00002E98 File Offset: 0x00001098
		[Token(Token = "0x17000091")]
		public bool CreateClipSurfaceData
		{
			[Token(Token = "0x600023B")]
			[Address(RVA = "0xA03DF0", Offset = "0xA023F0", VA = "0x180A03DF0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00002EB0 File Offset: 0x000010B0
		[Token(Token = "0x600023C")]
		[Address(RVA = "0xA03E00", Offset = "0xA02400", VA = "0x180A03E00")]
		public bool IsCrestActive()
		{
			return default(bool);
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x0600023D RID: 573 RVA: 0x00002EC8 File Offset: 0x000010C8
		// (set) Token: 0x0600023E RID: 574 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000092")]
		public float Scale
		{
			[Token(Token = "0x600023D")]
			[Address(RVA = "0xA03E10", Offset = "0xA02410", VA = "0x180A03E10")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600023E")]
			[Address(RVA = "0xA03E20", Offset = "0xA02420", VA = "0x180A03E20")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600023F RID: 575 RVA: 0x00002EE0 File Offset: 0x000010E0
		[Token(Token = "0x600023F")]
		[Address(RVA = "0xA03E30", Offset = "0xA02430", VA = "0x180A03E30")]
		public float CalcLodScale(float lodIndex)
		{
			return 0f;
		}

		// Token: 0x06000240 RID: 576 RVA: 0x00002EF8 File Offset: 0x000010F8
		[Token(Token = "0x6000240")]
		[Address(RVA = "0xA03E60", Offset = "0xA02460", VA = "0x180A03E60")]
		public float CalcGridSize(int lodIndex)
		{
			return 0f;
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x06000241 RID: 577 RVA: 0x00002F10 File Offset: 0x00001110
		// (set) Token: 0x06000242 RID: 578 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000093")]
		public float ViewerAltitudeLevelAlpha
		{
			[Token(Token = "0x6000241")]
			[Address(RVA = "0xA03EA0", Offset = "0xA024A0", VA = "0x180A03EA0")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000242")]
			[Address(RVA = "0xA03EB0", Offset = "0xA024B0", VA = "0x180A03EB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000243 RID: 579 RVA: 0x00002F28 File Offset: 0x00001128
		[Token(Token = "0x6000243")]
		[Address(RVA = "0xA03EC0", Offset = "0xA024C0", VA = "0x180A03EC0")]
		public float GetSeaLevel()
		{
			return 0f;
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x06000244 RID: 580 RVA: 0x00002F40 File Offset: 0x00001140
		[Token(Token = "0x17000094")]
		public int CurrentLodCount
		{
			[Token(Token = "0x6000244")]
			[Address(RVA = "0xA04030", Offset = "0xA02630", VA = "0x180A04030")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x06000245 RID: 581 RVA: 0x00002F58 File Offset: 0x00001158
		// (set) Token: 0x06000246 RID: 582 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000095")]
		public float ViewerHeightAboveWater
		{
			[Token(Token = "0x6000245")]
			[Address(RVA = "0xA04050", Offset = "0xA02650", VA = "0x180A04050")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000246")]
			[Address(RVA = "0xA04060", Offset = "0xA02660", VA = "0x180A04060")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000247 RID: 583 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000096")]
		public List<OceanChunkRenderer> Tiles
		{
			[Token(Token = "0x6000247")]
			[Address(RVA = "0xA04070", Offset = "0xA02670", VA = "0x180A04070")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000248 RID: 584 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000249 RID: 585 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000001")]
		public event OceanRenderer.EventHandler ViewerLessThan2mAboveWater
		{
			[Token(Token = "0x6000248")]
			[Address(RVA = "0xA04080", Offset = "0xA02680", VA = "0x180A04080")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000249")]
			[Address(RVA = "0xA04170", Offset = "0xA02770", VA = "0x180A04170")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x0600024A RID: 586 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x0600024B RID: 587 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000002")]
		public event OceanRenderer.EventHandler ViewerMoreThan2mAboveWater
		{
			[Token(Token = "0x600024A")]
			[Address(RVA = "0xA04260", Offset = "0xA02860", VA = "0x180A04260")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x600024B")]
			[Address(RVA = "0xA04350", Offset = "0xA02950", VA = "0x180A04350")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x0600024C RID: 588 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x0600024D RID: 589 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000097")]
		public static OceanRenderer Instance
		{
			[Token(Token = "0x600024C")]
			[Address(RVA = "0xA04440", Offset = "0xA02A40", VA = "0x180A04440")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600024D")]
			[Address(RVA = "0xA04490", Offset = "0xA02A90", VA = "0x180A04490")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600024E RID: 590 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024E")]
		[Address(RVA = "0xA04540", Offset = "0xA02B40", VA = "0x180A04540")]
		private void OnEnable()
		{
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600024F")]
		[Address(RVA = "0xA05150", Offset = "0xA03750", VA = "0x180A05150")]
		private void OnDisable()
		{
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000250 RID: 592 RVA: 0x00002F70 File Offset: 0x00001170
		[Token(Token = "0x17000098")]
		public static int FrameCount
		{
			[Token(Token = "0x6000250")]
			[Address(RVA = "0xA05230", Offset = "0xA03830", VA = "0x180A05230")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000251")]
		[Address(RVA = "0xA05280", Offset = "0xA03880", VA = "0x180A05280")]
		private void CreateDestroySubSystems()
		{
		}

		// Token: 0x06000252 RID: 594 RVA: 0x00002F88 File Offset: 0x00001188
		[Token(Token = "0x6000252")]
		[Address(RVA = "0xA06130", Offset = "0xA04730", VA = "0x180A06130")]
		private bool VerifyRequirements()
		{
			return default(bool);
		}

		// Token: 0x06000253 RID: 595 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000253")]
		[Address(RVA = "0xA06440", Offset = "0xA04A40", VA = "0x180A06440")]
		private void ValidateViewpoint()
		{
		}

		// Token: 0x06000254 RID: 596 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000254")]
		[Address(RVA = "0xA06500", Offset = "0xA04B00", VA = "0x180A06500")]
		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.SubsystemRegistration)]
		private static void InitStatics()
		{
		}

		// Token: 0x06000255 RID: 597 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000255")]
		[Address(RVA = "0xA06680", Offset = "0xA04C80", VA = "0x180A06680")]
		private void LateUpdate()
		{
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000256")]
		[Address(RVA = "0xA068B0", Offset = "0xA04EB0", VA = "0x180A068B0")]
		private void RunUpdate()
		{
		}

		// Token: 0x06000257 RID: 599 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000257")]
		[Address(RVA = "0xA069E0", Offset = "0xA04FE0", VA = "0x180A069E0")]
		private void UpdateCrest()
		{
		}

		// Token: 0x06000258 RID: 600 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000258")]
		[Address(RVA = "0xA071A0", Offset = "0xA057A0", VA = "0x180A071A0")]
		public void SetOverrideDisable(bool value)
		{
		}

		// Token: 0x06000259 RID: 601 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000259")]
		[Address(RVA = "0xA071B0", Offset = "0xA057B0", VA = "0x180A071B0")]
		private void UpdateOceanStandin()
		{
		}

		// Token: 0x0600025A RID: 602 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025A")]
		[Address(RVA = "0xA07630", Offset = "0xA05C30", VA = "0x180A07630")]
		private void WritePerFrameMaterialParams()
		{
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025B")]
		[Address(RVA = "0xA077B0", Offset = "0xA05DB0", VA = "0x180A077B0")]
		private void WritePerCascadeInstanceData(OceanRenderer.PerCascadeInstanceData[] instanceData)
		{
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025C")]
		[Address(RVA = "0xA07A00", Offset = "0xA06000", VA = "0x180A07A00")]
		private void LateUpdatePosition()
		{
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025D")]
		[Address(RVA = "0xA07D70", Offset = "0xA06370", VA = "0x180A07D70")]
		private void LateUpdatePrimaryLight()
		{
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025E")]
		[Address(RVA = "0xA081E0", Offset = "0xA067E0", VA = "0x180A081E0")]
		private void LateUpdateScale()
		{
		}

		// Token: 0x0600025F RID: 607 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600025F")]
		[Address(RVA = "0xA08450", Offset = "0xA06A50", VA = "0x180A08450")]
		private void LateUpdateViewerHeight()
		{
		}

		// Token: 0x06000260 RID: 608 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000260")]
		[Address(RVA = "0xA08680", Offset = "0xA06C80", VA = "0x180A08680")]
		private void LateUpdateLods()
		{
		}

		// Token: 0x06000261 RID: 609 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000261")]
		[Address(RVA = "0xA08780", Offset = "0xA06D80", VA = "0x180A08780")]
		private void LateUpdateTiles()
		{
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000262")]
		[Address(RVA = "0xA092A0", Offset = "0xA078A0", VA = "0x180A092A0")]
		private void LateUpdateResetMaxDisplacementFromShape()
		{
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000263 RID: 611 RVA: 0x00002FA0 File Offset: 0x000011A0
		[Token(Token = "0x17000099")]
		public bool ScaleCouldIncrease
		{
			[Token(Token = "0x6000263")]
			[Address(RVA = "0xA09390", Offset = "0xA07990", VA = "0x180A09390")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000264 RID: 612 RVA: 0x00002FB8 File Offset: 0x000011B8
		[Token(Token = "0x1700009A")]
		public bool ScaleCouldDecrease
		{
			[Token(Token = "0x6000264")]
			[Address(RVA = "0xA09440", Offset = "0xA07A40", VA = "0x180A09440")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000265")]
		[Address(RVA = "0xA094F0", Offset = "0xA07AF0", VA = "0x180A094F0")]
		public void ReportMaxDisplacementFromShape(float maxHorizDisp, float maxVertDisp, float maxVertDispFromWaves)
		{
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000266 RID: 614 RVA: 0x00002FD0 File Offset: 0x000011D0
		[Token(Token = "0x1700009B")]
		public float MaxHorizDisplacement
		{
			[Token(Token = "0x6000266")]
			[Address(RVA = "0xA09530", Offset = "0xA07B30", VA = "0x180A09530")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000267 RID: 615 RVA: 0x00002FE8 File Offset: 0x000011E8
		[Token(Token = "0x1700009C")]
		public float MaxVertDisplacement
		{
			[Token(Token = "0x6000267")]
			[Address(RVA = "0xA09540", Offset = "0xA07B40", VA = "0x180A09540")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000268 RID: 616 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x06000269 RID: 617 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009D")]
		public ICollProvider CollisionProvider
		{
			[Token(Token = "0x6000268")]
			[Address(RVA = "0xA09550", Offset = "0xA07B50", VA = "0x180A09550")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000269")]
			[Address(RVA = "0xA09560", Offset = "0xA07B60", VA = "0x180A09560")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600026A RID: 618 RVA: 0x000020E2 File Offset: 0x000002E2
		// (set) Token: 0x0600026B RID: 619 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700009E")]
		public IFlowProvider FlowProvider
		{
			[Token(Token = "0x600026A")]
			[Address(RVA = "0xA095C0", Offset = "0xA07BC0", VA = "0x180A095C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600026B")]
			[Address(RVA = "0xA095D0", Offset = "0xA07BD0", VA = "0x180A095D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600026C RID: 620 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026C")]
		[Address(RVA = "0xA09630", Offset = "0xA07C30", VA = "0x180A09630")]
		private void CleanUp()
		{
		}

		// Token: 0x0600026D RID: 621 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600026D")]
		[Address(RVA = "0xA09D30", Offset = "0xA08330", VA = "0x180A09D30")]
		public OceanRenderer()
		{
		}

		// Token: 0x040001A6 RID: 422
		[Token(Token = "0x40001A6")]
		private const string MissingSunLightErrorMessage = "Crest needs to know which light to use as the sun light. Please assign the primary light in the scene to the Primary Light field on the OceanRenderer component. Click this message to select the GameObject with this component.";

		// Token: 0x040001A7 RID: 423
		[Token(Token = "0x40001A7")]
		private const string MissingCameraErrorMessage = "Crest needs to know where to focus the ocean detail. Please set the <i>ViewCamera</i> or the <i>Viewpoint</i> property that will render the ocean, or tag the primary camera as <i>MainCamera</i>.";

		// Token: 0x040001A8 RID: 424
		[Token(Token = "0x40001A8")]
		[FieldOffset(Offset = "0x20")]
		[Tooltip("Base wind speed in km/h. Controls wave conditions. Can be overridden on ShapeGerstner components.")]
		[Range(0f, 150f)]
		public float _globalWindSpeed;

		// Token: 0x040001A9 RID: 425
		[Token(Token = "0x40001A9")]
		[FieldOffset(Offset = "0x28")]
		[Tooltip("The viewpoint which drives the ocean detail. Defaults to the camera.")]
		[SerializeField]
		private Transform _viewpoint;

		// Token: 0x040001AA RID: 426
		[Token(Token = "0x40001AA")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Tooltip("The camera which drives the ocean data. Defaults to main camera.")]
		private Camera _camera;

		// Token: 0x040001AC RID: 428
		[Token(Token = "0x40001AC")]
		[FieldOffset(Offset = "0x40")]
		[Tooltip("Optional provider for time, can be used to hard-code time for automation, or provide server time. Defaults to local Unity time.")]
		[SerializeField]
		private TimeProviderBase _timeProvider;

		// Token: 0x040001AD RID: 429
		[Token(Token = "0x40001AD")]
		[FieldOffset(Offset = "0x48")]
		private TimeProviderDefault _timeProviderDefault;

		// Token: 0x040001AE RID: 430
		[Token(Token = "0x40001AE")]
		[FieldOffset(Offset = "0x50")]
		private bool _useOceanStandin;

		// Token: 0x040001AF RID: 431
		[Token(Token = "0x40001AF")]
		[FieldOffset(Offset = "0x58")]
		[Tooltip("The primary directional light.")]
		public Light _primaryLight;

		// Token: 0x040001B0 RID: 432
		[Token(Token = "0x40001B0")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("If Primary Light is not set, search the scene for all directional lights and pick the brightest to use as the sun light.")]
		[PredicatedField("_primaryLight", true, 0)]
		[SerializeField]
		private bool _searchForPrimaryLightOnStartup;

		// Token: 0x040001B1 RID: 433
		[Token(Token = "0x40001B1")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		[Tooltip("Material to use for the ocean surface")]
		[Header("Ocean Params")]
		private Material _material;

		// Token: 0x040001B3 RID: 435
		[Token(Token = "0x40001B3")]
		[FieldOffset(Offset = "0x80")]
		[SerializeField]
		private string _layerName;

		// Token: 0x040001B4 RID: 436
		[Token(Token = "0x40001B4")]
		[FieldOffset(Offset = "0x88")]
		[Delayed]
		[Range(0f, 10f)]
		[Tooltip("Multiplier for physics gravity.")]
		[SerializeField]
		private float _gravityMultiplier;

		// Token: 0x040001B5 RID: 437
		[Token(Token = "0x40001B5")]
		[FieldOffset(Offset = "0x8C")]
		[Tooltip("Min number of verts / shape texels per wave.")]
		[SerializeField]
		[Header("Detail Params")]
		[Range(2f, 16f)]
		private float _minTexelsPerWave;

		// Token: 0x040001B6 RID: 438
		[Token(Token = "0x40001B6")]
		[FieldOffset(Offset = "0x90")]
		[Delayed]
		[Tooltip("The smallest scale the ocean can be.")]
		[SerializeField]
		private float _minScale;

		// Token: 0x040001B7 RID: 439
		[Token(Token = "0x40001B7")]
		[FieldOffset(Offset = "0x94")]
		[Tooltip("The largest scale the ocean can be (-1 for unlimited).")]
		[Delayed]
		[SerializeField]
		private float _maxScale;

		// Token: 0x040001B8 RID: 440
		[Token(Token = "0x40001B8")]
		[FieldOffset(Offset = "0x98")]
		[Range(0f, 1f)]
		[Tooltip("Drops the height for maximum ocean detail based on waves. This means if there are big waves, max detail level is reached at a lower height, which can help visual range when there are very large waves and camera is at sea level.")]
		[SerializeField]
		private float _dropDetailHeightBasedOnWaves;

		// Token: 0x040001B9 RID: 441
		[Token(Token = "0x40001B9")]
		[FieldOffset(Offset = "0x9C")]
		[SerializeField]
		[Delayed]
		[Tooltip("Resolution of ocean LOD data. Use even numbers like 256 or 384. This is 4x the old 'Base Vert Density' param, so if you used 64 for this param, set this to 256. Press 'Rebuild Ocean' button below to apply.")]
		private int _lodDataResolution;

		// Token: 0x040001BA RID: 442
		[Token(Token = "0x40001BA")]
		[FieldOffset(Offset = "0xA0")]
		[SerializeField]
		[Delayed]
		[Tooltip("How much of the water shape gets tessellated by geometry. If set to e.g. 4, every geometry quad will span 4x4 LOD data texels. Use power of 2 values like 1, 2, 4... Press 'Rebuild Ocean' button below to apply.")]
		private int _geometryDownSampleFactor;

		// Token: 0x040001BB RID: 443
		[Token(Token = "0x40001BB")]
		[FieldOffset(Offset = "0xA4")]
		[SerializeField]
		[Tooltip("Number of ocean tile scales/LODs to generate. Press 'Rebuild Ocean' button below to apply.")]
		[Range(2f, 15f)]
		private int _lodCount;

		// Token: 0x040001BC RID: 444
		[Token(Token = "0x40001BC")]
		[FieldOffset(Offset = "0xA8")]
		[Tooltip("Proportion of visibility below which ocean will be culled underwater. The larger the number, the closer to the camera the ocean tiles will be culled.")]
		[SerializeField]
		[Range(1E-06f, 0.01f)]
		public float _underwaterCullLimit;

		// Token: 0x040001BD RID: 445
		[Token(Token = "0x40001BD")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		[Header("Rendering Params")]
		[Tooltip("Layer mask for lights and shadows. Please read the HDRP documentation on light layers for more information.")]
		private LightLayerEnum _renderingLayerMask;

		// Token: 0x040001BE RID: 446
		[Token(Token = "0x40001BE")]
		[FieldOffset(Offset = "0xB0")]
		[Tooltip("Mask object for underwater")]
		[SerializeField]
		private GameObject _underwaterCustomPassVolumeObject;

		// Token: 0x040001BF RID: 447
		[Token(Token = "0x40001BF")]
		[FieldOffset(Offset = "0xB8")]
		[Header("Simulation Params")]
		public SimSettingsAnimatedWaves _simSettingsAnimatedWaves;

		// Token: 0x040001C0 RID: 448
		[Token(Token = "0x40001C0")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Tooltip("Water depth information used for shallow water, shoreline foam, wave attenuation, among others.")]
		private bool _createSeaFloorDepthData;

		// Token: 0x040001C1 RID: 449
		[Token(Token = "0x40001C1")]
		[FieldOffset(Offset = "0xC1")]
		[Tooltip("Simulation of foam created in choppy water and dissipating over time.")]
		[SerializeField]
		private bool _createFoamSim;

		// Token: 0x040001C2 RID: 450
		[Token(Token = "0x40001C2")]
		[FieldOffset(Offset = "0xC8")]
		[PredicatedField("_createFoamSim", false, 0)]
		public SimSettingsFoam _simSettingsFoam;

		// Token: 0x040001C3 RID: 451
		[Token(Token = "0x40001C3")]
		[FieldOffset(Offset = "0xD0")]
		[Tooltip("Dynamic waves generated from interactions with objects such as boats.")]
		[SerializeField]
		private bool _createDynamicWaveSim;

		// Token: 0x040001C4 RID: 452
		[Token(Token = "0x40001C4")]
		[FieldOffset(Offset = "0xD8")]
		[PredicatedField("_createDynamicWaveSim", false, 0)]
		public SimSettingsWave _simSettingsDynamicWaves;

		// Token: 0x040001C5 RID: 453
		[Token(Token = "0x40001C5")]
		[FieldOffset(Offset = "0xE0")]
		[Tooltip("Horizontal motion of water body, akin to water currents.")]
		[SerializeField]
		private bool _createFlowSim;

		// Token: 0x040001C6 RID: 454
		[Token(Token = "0x40001C6")]
		[FieldOffset(Offset = "0xE8")]
		[PredicatedField("_createFlowSim", false, 0)]
		public SimSettingsFlow _simSettingsFlow;

		// Token: 0x040001C7 RID: 455
		[Token(Token = "0x40001C7")]
		[FieldOffset(Offset = "0xF0")]
		[Tooltip("Shadow information used for lighting water.")]
		[SerializeField]
		private bool _createShadowData;

		// Token: 0x040001C8 RID: 456
		[Token(Token = "0x40001C8")]
		[FieldOffset(Offset = "0xF8")]
		[PredicatedField("_createShadowData", false, 0)]
		public SimSettingsShadow _simSettingsShadow;

		// Token: 0x040001C9 RID: 457
		[Token(Token = "0x40001C9")]
		[FieldOffset(Offset = "0x100")]
		[SerializeField]
		[Tooltip("Clip surface information for clipping the ocean surface.")]
		private bool _createClipSurfaceData;

		// Token: 0x040001CA RID: 458
		[Token(Token = "0x40001CA")]
		[FieldOffset(Offset = "0x104")]
		[PredicatedField("_createClipSurfaceData", false, 0)]
		[Tooltip("Whether to clip nothing by default (and clip inputs remove patches of surface), or to clip everything by default (and clip inputs add patches of surface).")]
		public OceanRenderer.DefaultClippingState _defaultClippingState;

		// Token: 0x040001CB RID: 459
		[Token(Token = "0x40001CB")]
		[FieldOffset(Offset = "0x108")]
		[Header("Edit Mode Params")]
		[Tooltip("Apply a test material based on a simple test shadergraph, useful for checking how lighting behaves on a standard shader.")]
		[SerializeField]
		private bool _applyTestMaterial;

		// Token: 0x040001CC RID: 460
		[Token(Token = "0x40001CC")]
		[FieldOffset(Offset = "0x109")]
		[SerializeField]
		private bool _showOceanProxyPlane;

		// Token: 0x040001CD RID: 461
		[Token(Token = "0x40001CD")]
		[FieldOffset(Offset = "0x10C")]
		[Tooltip("Sets the update rate of the ocean system when in edit mode. Can be reduced to save power.")]
		[Range(0f, 60f)]
		[SerializeField]
		private float _editModeFPS;

		// Token: 0x040001CE RID: 462
		[Token(Token = "0x40001CE")]
		[FieldOffset(Offset = "0x110")]
		[SerializeField]
		[Tooltip("Move ocean with Scene view camera if Scene window is focused.")]
		[PredicatedField("_showOceanProxyPlane", true, 0)]
		private bool _followSceneCamera;

		// Token: 0x040001CF RID: 463
		[Token(Token = "0x40001CF")]
		[FieldOffset(Offset = "0x118")]
		[Header("Probe Anchor")]
		public Transform _probeAnchor;

		// Token: 0x040001D0 RID: 464
		[Token(Token = "0x40001D0")]
		[FieldOffset(Offset = "0x120")]
		[Header("Occluders")]
		public CrestOceanOccluder[] _waterOccluders;

		// Token: 0x040001D1 RID: 465
		[Token(Token = "0x40001D1")]
		[FieldOffset(Offset = "0x128")]
		[Space(15f)]
		[Header("Placeholder")]
		public Renderer _placeHolderRenderer;

		// Token: 0x040001D2 RID: 466
		[Token(Token = "0x40001D2")]
		[FieldOffset(Offset = "0x130")]
		public Material _placeHolderMat;

		// Token: 0x040001D3 RID: 467
		[Token(Token = "0x40001D3")]
		[FieldOffset(Offset = "0x138")]
		public float _switchHeight;

		// Token: 0x040001D4 RID: 468
		[Token(Token = "0x40001D4")]
		[FieldOffset(Offset = "0x13C")]
		public int _transition;

		// Token: 0x040001D5 RID: 469
		[Token(Token = "0x40001D5")]
		[FieldOffset(Offset = "0x140")]
		private bool _placeHolderIsActive;

		// Token: 0x040001D6 RID: 470
		[Token(Token = "0x40001D6")]
		[FieldOffset(Offset = "0x141")]
		private bool _crestIsActive;

		// Token: 0x040001D7 RID: 471
		[Token(Token = "0x40001D7")]
		[FieldOffset(Offset = "0x144")]
		private float _placeHolderCurrentAlpha;

		// Token: 0x040001D8 RID: 472
		[Token(Token = "0x40001D8")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _PlaceholderAlpha;

		// Token: 0x040001D9 RID: 473
		[Token(Token = "0x40001D9")]
		[FieldOffset(Offset = "0x148")]
		[Tooltip("Attach debug gui that adds some controls and allows to visualise the ocean data.")]
		[Header("Debug Params")]
		[SerializeField]
		private bool _attachDebugGUI;

		// Token: 0x040001DA RID: 474
		[Token(Token = "0x40001DA")]
		[FieldOffset(Offset = "0x149")]
		[Tooltip("Move ocean with viewpoint.")]
		private bool _followViewpoint;

		// Token: 0x040001DB RID: 475
		[Token(Token = "0x40001DB")]
		[FieldOffset(Offset = "0x14A")]
		[Tooltip("Set the ocean surface tiles hidden by default to clean up the hierarchy.")]
		public bool _hideOceanTileGameObjects;

		// Token: 0x040001DC RID: 476
		[Token(Token = "0x40001DC")]
		[FieldOffset(Offset = "0x14B")]
		[HideInInspector]
		[Tooltip("Whether to generate ocean geometry tiles uniformly (with overlaps).")]
		public bool _uniformTiles;

		// Token: 0x040001DD RID: 477
		[Token(Token = "0x40001DD")]
		[FieldOffset(Offset = "0x14C")]
		[HideInInspector]
		[Tooltip("Disable generating a wide strip of triangles at the outer edge to extend ocean to edge of view frustum.")]
		public bool _disableSkirt;

		// Token: 0x040001E0 RID: 480
		[Token(Token = "0x40001E0")]
		[FieldOffset(Offset = "0x158")]
		[HideInInspector]
		public LodTransform _lodTransform;

		// Token: 0x040001E1 RID: 481
		[Token(Token = "0x40001E1")]
		[FieldOffset(Offset = "0x160")]
		[HideInInspector]
		public LodDataMgrAnimWaves _lodDataAnimWaves;

		// Token: 0x040001E2 RID: 482
		[Token(Token = "0x40001E2")]
		[FieldOffset(Offset = "0x168")]
		[HideInInspector]
		public LodDataMgrSeaFloorDepth _lodDataSeaDepths;

		// Token: 0x040001E3 RID: 483
		[Token(Token = "0x40001E3")]
		[FieldOffset(Offset = "0x170")]
		[HideInInspector]
		public LodDataMgrClipSurface _lodDataClipSurface;

		// Token: 0x040001E4 RID: 484
		[Token(Token = "0x40001E4")]
		[FieldOffset(Offset = "0x178")]
		[HideInInspector]
		public LodDataMgrDynWaves _lodDataDynWaves;

		// Token: 0x040001E5 RID: 485
		[Token(Token = "0x40001E5")]
		[FieldOffset(Offset = "0x180")]
		[HideInInspector]
		public LodDataMgrFlow _lodDataFlow;

		// Token: 0x040001E6 RID: 486
		[Token(Token = "0x40001E6")]
		[FieldOffset(Offset = "0x188")]
		[HideInInspector]
		public LodDataMgrFoam _lodDataFoam;

		// Token: 0x040001E7 RID: 487
		[Token(Token = "0x40001E7")]
		[FieldOffset(Offset = "0x190")]
		[HideInInspector]
		public LodDataMgrShadow _lodDataShadow;

		// Token: 0x040001E9 RID: 489
		[Token(Token = "0x40001E9")]
		[FieldOffset(Offset = "0x1A0")]
		private List<LodDataMgr> _lodDatas;

		// Token: 0x040001EA RID: 490
		[Token(Token = "0x40001EA")]
		[FieldOffset(Offset = "0x1A8")]
		private List<OceanChunkRenderer> _oceanChunkRenderers;

		// Token: 0x040001EB RID: 491
		[Token(Token = "0x40001EB")]
		[FieldOffset(Offset = "0x1B0")]
		private SampleHeightHelper _sampleHeightHelper;

		// Token: 0x040001EE RID: 494
		[Token(Token = "0x40001EE")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int sp_primaryLightDirection;

		// Token: 0x040001EF RID: 495
		[Token(Token = "0x40001EF")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int sp_primaryLightIntensity;

		// Token: 0x040001F1 RID: 497
		[Token(Token = "0x40001F1")]
		[FieldOffset(Offset = "0x1C8")]
		private float _lodAlphaBlackPointFade;

		// Token: 0x040001F2 RID: 498
		[Token(Token = "0x40001F2")]
		[FieldOffset(Offset = "0x1CC")]
		private float _lodAlphaBlackPointWhitePointFade;

		// Token: 0x040001F3 RID: 499
		[Token(Token = "0x40001F3")]
		[FieldOffset(Offset = "0x1D0")]
		private bool _canSkipCulling;

		// Token: 0x040001F4 RID: 500
		[Token(Token = "0x40001F4")]
		[FieldOffset(Offset = "0x18")]
		public static int sp_crestTime;

		// Token: 0x040001F5 RID: 501
		[Token(Token = "0x40001F5")]
		[FieldOffset(Offset = "0x1D4")]
		private readonly int sp_texelsPerWave;

		// Token: 0x040001F6 RID: 502
		[Token(Token = "0x40001F6")]
		[FieldOffset(Offset = "0x1D8")]
		private readonly int sp_oceanCenterPosWorld;

		// Token: 0x040001F7 RID: 503
		[Token(Token = "0x40001F7")]
		[FieldOffset(Offset = "0x1DC")]
		private readonly int sp_meshScaleLerp;

		// Token: 0x040001F8 RID: 504
		[Token(Token = "0x40001F8")]
		[FieldOffset(Offset = "0x1E0")]
		private bool _firstViewerHeightUpdate;

		// Token: 0x040001F9 RID: 505
		[Token(Token = "0x40001F9")]
		[FieldOffset(Offset = "0x1E4")]
		private readonly int sp_sliceCount;

		// Token: 0x040001FA RID: 506
		[Token(Token = "0x40001FA")]
		[FieldOffset(Offset = "0x1E8")]
		private readonly int sp_clipByDefault;

		// Token: 0x040001FB RID: 507
		[Token(Token = "0x40001FB")]
		[FieldOffset(Offset = "0x1EC")]
		private readonly int sp_lodAlphaBlackPointFade;

		// Token: 0x040001FC RID: 508
		[Token(Token = "0x40001FC")]
		[FieldOffset(Offset = "0x1F0")]
		private readonly int sp_lodAlphaBlackPointWhitePointFade;

		// Token: 0x040001FD RID: 509
		[Token(Token = "0x40001FD")]
		[FieldOffset(Offset = "0x1C")]
		private static int sp_ForceUnderwater;

		// Token: 0x040001FE RID: 510
		[Token(Token = "0x40001FE")]
		[FieldOffset(Offset = "0x20")]
		public static int sp_perCascadeInstanceData;

		// Token: 0x040001FF RID: 511
		[Token(Token = "0x40001FF")]
		[FieldOffset(Offset = "0x24")]
		public static int sp_cascadeData;

		// Token: 0x04000200 RID: 512
		[Token(Token = "0x4000200")]
		[FieldOffset(Offset = "0x1F8")]
		private BuildCommandBuffer _commandbufferBuilder;

		// Token: 0x04000201 RID: 513
		[Token(Token = "0x4000201")]
		[FieldOffset(Offset = "0x200")]
		public ComputeBuffer _bufCascadeDataTgt;

		// Token: 0x04000202 RID: 514
		[Token(Token = "0x4000202")]
		[FieldOffset(Offset = "0x208")]
		public ComputeBuffer _bufCascadeDataSrc;

		// Token: 0x04000203 RID: 515
		[Token(Token = "0x4000203")]
		[FieldOffset(Offset = "0x210")]
		public ComputeBuffer _bufPerCascadeInstanceData;

		// Token: 0x04000204 RID: 516
		[Token(Token = "0x4000204")]
		[FieldOffset(Offset = "0x218")]
		private OceanRenderer.CascadeParams[] _cascadeParamsSrc;

		// Token: 0x04000205 RID: 517
		[Token(Token = "0x4000205")]
		[FieldOffset(Offset = "0x220")]
		private OceanRenderer.CascadeParams[] _cascadeParamsTgt;

		// Token: 0x04000206 RID: 518
		[Token(Token = "0x4000206")]
		[FieldOffset(Offset = "0x228")]
		private OceanRenderer.PerCascadeInstanceData[] _perCascadeInstanceData;

		// Token: 0x04000207 RID: 519
		[Token(Token = "0x4000207")]
		[FieldOffset(Offset = "0x230")]
		private float _maxHorizDispFromShape;

		// Token: 0x04000208 RID: 520
		[Token(Token = "0x4000208")]
		[FieldOffset(Offset = "0x234")]
		private float _maxVertDispFromShape;

		// Token: 0x04000209 RID: 521
		[Token(Token = "0x4000209")]
		[FieldOffset(Offset = "0x238")]
		private float _maxVertDispFromWaves;

		// Token: 0x0400020A RID: 522
		[Token(Token = "0x400020A")]
		[FieldOffset(Offset = "0x23C")]
		private int _maxDisplacementCachedTime;

		// Token: 0x0400020B RID: 523
		[Token(Token = "0x400020B")]
		[FieldOffset(Offset = "0x240")]
		private Camera _cameraCachedFrame;

		// Token: 0x0400020C RID: 524
		[Token(Token = "0x400020C")]
		[FieldOffset(Offset = "0x248")]
		private int _cameraCacheFrameCount;

		// Token: 0x0400020D RID: 525
		[Token(Token = "0x400020D")]
		[FieldOffset(Offset = "0x24C")]
		private bool _overrideDisable;

		// Token: 0x0400020E RID: 526
		[Token(Token = "0x400020E")]
		[FieldOffset(Offset = "0x24D")]
		private bool _hasCachedSeaLevel;

		// Token: 0x0400020F RID: 527
		[Token(Token = "0x400020F")]
		[FieldOffset(Offset = "0x250")]
		private float _cachedSeaLevel;

		// Token: 0x02000062 RID: 98
		[Token(Token = "0x2000062")]
		public enum DefaultClippingState
		{
			// Token: 0x04000213 RID: 531
			[Token(Token = "0x4000213")]
			NothingClipped,
			// Token: 0x04000214 RID: 532
			[Token(Token = "0x4000214")]
			EverythingClipped
		}

		// Token: 0x02000063 RID: 99
		// (Invoke) Token: 0x06000270 RID: 624
		[Token(Token = "0x2000063")]
		public delegate void EventHandler(OceanRenderer ocean);

		// Token: 0x02000064 RID: 100
		[Token(Token = "0x2000064")]
		public struct CascadeParams
		{
			// Token: 0x04000215 RID: 533
			[Token(Token = "0x4000215")]
			[FieldOffset(Offset = "0x0")]
			public Vector2 _posSnapped;

			// Token: 0x04000216 RID: 534
			[Token(Token = "0x4000216")]
			[FieldOffset(Offset = "0x8")]
			public float _scale;

			// Token: 0x04000217 RID: 535
			[Token(Token = "0x4000217")]
			[FieldOffset(Offset = "0xC")]
			public float _textureRes;

			// Token: 0x04000218 RID: 536
			[Token(Token = "0x4000218")]
			[FieldOffset(Offset = "0x10")]
			public float _oneOverTextureRes;

			// Token: 0x04000219 RID: 537
			[Token(Token = "0x4000219")]
			[FieldOffset(Offset = "0x14")]
			public float _texelWidth;

			// Token: 0x0400021A RID: 538
			[Token(Token = "0x400021A")]
			[FieldOffset(Offset = "0x18")]
			public float _weight;

			// Token: 0x0400021B RID: 539
			[Token(Token = "0x400021B")]
			[FieldOffset(Offset = "0x1C")]
			public float __padding;
		}

		// Token: 0x02000065 RID: 101
		[Token(Token = "0x2000065")]
		public struct PerCascadeInstanceData
		{
			// Token: 0x0400021C RID: 540
			[Token(Token = "0x400021C")]
			[FieldOffset(Offset = "0x0")]
			public float _meshScaleLerp;

			// Token: 0x0400021D RID: 541
			[Token(Token = "0x400021D")]
			[FieldOffset(Offset = "0x4")]
			public float _farNormalsWeight;

			// Token: 0x0400021E RID: 542
			[Token(Token = "0x400021E")]
			[FieldOffset(Offset = "0x8")]
			public float _geoGridWidth;

			// Token: 0x0400021F RID: 543
			[Token(Token = "0x400021F")]
			[FieldOffset(Offset = "0xC")]
			public Vector2 _normalScrollSpeeds;

			// Token: 0x04000220 RID: 544
			[Token(Token = "0x4000220")]
			[FieldOffset(Offset = "0x14")]
			public Vector3 __padding;
		}
	}
}
