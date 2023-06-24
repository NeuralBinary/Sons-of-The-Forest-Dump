using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Unity.Profiling;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001A4 RID: 420
	[Token(Token = "0x20001A4")]
	[DisallowMultipleComponent]
	[ExecuteInEditMode]
	[AddComponentMenu("Physics/Obi/Obi Solver", 800)]
	public sealed class ObiSolver : MonoBehaviour
	{
		// Token: 0x1400000B RID: 11
		// (add) Token: 0x060007E5 RID: 2021 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060007E6 RID: 2022 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1400000B")]
		public event ObiSolver.CollisionCallback OnCollision
		{
			[Token(Token = "0x60007E5")]
			[Address(RVA = "0x27E6990", Offset = "0x27E4F90", VA = "0x1827E6990")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007E6")]
			[Address(RVA = "0x27E6A80", Offset = "0x27E5080", VA = "0x1827E6A80")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x060007E7 RID: 2023 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060007E8 RID: 2024 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1400000C")]
		public event ObiSolver.CollisionCallback OnParticleCollision
		{
			[Token(Token = "0x60007E7")]
			[Address(RVA = "0x27E6B70", Offset = "0x27E5170", VA = "0x1827E6B70")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007E8")]
			[Address(RVA = "0x27E6C60", Offset = "0x27E5260", VA = "0x1827E6C60")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060007E9 RID: 2025 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060007EA RID: 2026 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1400000D")]
		public event ObiSolver.SolverCallback OnUpdateParameters
		{
			[Token(Token = "0x60007E9")]
			[Address(RVA = "0x27E6D50", Offset = "0x27E5350", VA = "0x1827E6D50")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007EA")]
			[Address(RVA = "0x27E6E40", Offset = "0x27E5440", VA = "0x1827E6E40")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x060007EB RID: 2027 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060007EC RID: 2028 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1400000E")]
		public event ObiSolver.SolverStepCallback OnPrepareStep
		{
			[Token(Token = "0x60007EB")]
			[Address(RVA = "0x27E6F30", Offset = "0x27E5530", VA = "0x1827E6F30")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007EC")]
			[Address(RVA = "0x27E7020", Offset = "0x27E5620", VA = "0x1827E7020")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060007ED RID: 2029 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060007EE RID: 2030 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1400000F")]
		public event ObiSolver.SolverStepCallback OnBeginStep
		{
			[Token(Token = "0x60007ED")]
			[Address(RVA = "0x27E7110", Offset = "0x27E5710", VA = "0x1827E7110")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007EE")]
			[Address(RVA = "0x27E7200", Offset = "0x27E5800", VA = "0x1827E7200")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060007EF RID: 2031 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060007F0 RID: 2032 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000010")]
		public event ObiSolver.SolverStepCallback OnSubstep
		{
			[Token(Token = "0x60007EF")]
			[Address(RVA = "0x27E72F0", Offset = "0x27E58F0", VA = "0x1827E72F0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007F0")]
			[Address(RVA = "0x27E73E0", Offset = "0x27E59E0", VA = "0x1827E73E0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060007F1 RID: 2033 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060007F2 RID: 2034 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000011")]
		public event ObiSolver.SolverCallback OnEndStep
		{
			[Token(Token = "0x60007F1")]
			[Address(RVA = "0x27E74D0", Offset = "0x27E5AD0", VA = "0x1827E74D0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007F2")]
			[Address(RVA = "0x27E75C0", Offset = "0x27E5BC0", VA = "0x1827E75C0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060007F3 RID: 2035 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x060007F4 RID: 2036 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000012")]
		public event ObiSolver.SolverCallback OnInterpolate
		{
			[Token(Token = "0x60007F3")]
			[Address(RVA = "0x27E76B0", Offset = "0x27E5CB0", VA = "0x1827E76B0")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60007F4")]
			[Address(RVA = "0x27E77A0", Offset = "0x27E5DA0", VA = "0x1827E77A0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060007F5 RID: 2037 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700010B")]
		public ISolverImpl implementation
		{
			[Token(Token = "0x60007F5")]
			[Address(RVA = "0x675FA0", Offset = "0x6745A0", VA = "0x180675FA0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060007F6 RID: 2038 RVA: 0x00004874 File Offset: 0x00002A74
		[Token(Token = "0x1700010C")]
		public bool initialized
		{
			[Token(Token = "0x60007F6")]
			[Address(RVA = "0x76BE10", Offset = "0x76A410", VA = "0x18076BE10")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060007F7 RID: 2039 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700010D")]
		public IObiBackend simulationBackend
		{
			[Token(Token = "0x60007F7")]
			[Address(RVA = "0x6F1D00", Offset = "0x6F0300", VA = "0x1806F1D00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060007F9 RID: 2041 RVA: 0x0000488C File Offset: 0x00002A8C
		// (set) Token: 0x060007F8 RID: 2040 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700010E")]
		public ObiSolver.BackendType backendType
		{
			[Token(Token = "0x60007F9")]
			[Address(RVA = "0xAFF270", Offset = "0xAFD870", VA = "0x180AFF270")]
			get
			{
				return ObiSolver.BackendType.Oni;
			}
			[Token(Token = "0x60007F8")]
			[Address(RVA = "0x27E7890", Offset = "0x27E5E90", VA = "0x1827E7890")]
			set
			{
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060007FA RID: 2042 RVA: 0x000048A4 File Offset: 0x00002AA4
		[Token(Token = "0x1700010F")]
		public SimplexCounts simplexCounts
		{
			[Token(Token = "0x60007FA")]
			[Address(RVA = "0x27E78A0", Offset = "0x27E5EA0", VA = "0x1827E78A0")]
			get
			{
				return default(SimplexCounts);
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060007FB RID: 2043 RVA: 0x000048BC File Offset: 0x00002ABC
		[Token(Token = "0x17000110")]
		public Bounds Bounds
		{
			[Token(Token = "0x60007FB")]
			[Address(RVA = "0x27E78C0", Offset = "0x27E5EC0", VA = "0x1827E78C0")]
			get
			{
				return default(Bounds);
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x000048D4 File Offset: 0x00002AD4
		[Token(Token = "0x17000111")]
		public bool IsVisible
		{
			[Token(Token = "0x60007FC")]
			[Address(RVA = "0x27E78E0", Offset = "0x27E5EE0", VA = "0x1827E78E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x000048EC File Offset: 0x00002AEC
		[Token(Token = "0x17000112")]
		public float maxScale
		{
			[Token(Token = "0x60007FD")]
			[Address(RVA = "0xA55A50", Offset = "0xA54050", VA = "0x180A55A50")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00004904 File Offset: 0x00002B04
		[Token(Token = "0x17000113")]
		public int allocParticleCount
		{
			[Token(Token = "0x60007FE")]
			[Address(RVA = "0x27E78F0", Offset = "0x27E5EF0", VA = "0x1827E78F0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060007FF RID: 2047 RVA: 0x0000491C File Offset: 0x00002B1C
		[Token(Token = "0x17000114")]
		public int pointCount
		{
			[Token(Token = "0x60007FF")]
			[Address(RVA = "0x27E7A60", Offset = "0x27E6060", VA = "0x1827E7A60")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x00004934 File Offset: 0x00002B34
		[Token(Token = "0x17000115")]
		public int edgeCount
		{
			[Token(Token = "0x6000800")]
			[Address(RVA = "0x27E7AA0", Offset = "0x27E60A0", VA = "0x1827E7AA0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000801 RID: 2049 RVA: 0x0000494C File Offset: 0x00002B4C
		[Token(Token = "0x17000116")]
		public int triCount
		{
			[Token(Token = "0x6000801")]
			[Address(RVA = "0x27E7AF0", Offset = "0x27E60F0", VA = "0x1827E7AF0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x00004964 File Offset: 0x00002B64
		[Token(Token = "0x17000117")]
		public int contactCount
		{
			[Token(Token = "0x6000802")]
			[Address(RVA = "0x27E7B40", Offset = "0x27E6140", VA = "0x1827E7B40")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x0000497C File Offset: 0x00002B7C
		[Token(Token = "0x17000118")]
		public int particleContactCount
		{
			[Token(Token = "0x6000803")]
			[Address(RVA = "0x27E7B50", Offset = "0x27E6150", VA = "0x1827E7B50")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000119")]
		public ObiSolver.ParticleInActor[] particleToActor
		{
			[Token(Token = "0x6000804")]
			[Address(RVA = "0x27E7B60", Offset = "0x27E6160", VA = "0x1827E7B60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000805 RID: 2053 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700011A")]
		public ObiNativeVector4List rigidbodyLinearDeltas
		{
			[Token(Token = "0x6000805")]
			[Address(RVA = "0x27E7C00", Offset = "0x27E6200", VA = "0x1827E7C00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700011B")]
		public ObiNativeVector4List rigidbodyAngularDeltas
		{
			[Token(Token = "0x6000806")]
			[Address(RVA = "0x27E7CB0", Offset = "0x27E62B0", VA = "0x1827E7CB0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000807 RID: 2055 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700011C")]
		public Color[] colors
		{
			[Token(Token = "0x6000807")]
			[Address(RVA = "0x27E7D60", Offset = "0x27E6360", VA = "0x1827E7D60")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000808 RID: 2056 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700011D")]
		public ObiNativeInt4List cellCoords
		{
			[Token(Token = "0x6000808")]
			[Address(RVA = "0x27E7E00", Offset = "0x27E6400", VA = "0x1827E7E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000809 RID: 2057 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700011E")]
		public ObiNativeVector4List positions
		{
			[Token(Token = "0x6000809")]
			[Address(RVA = "0x27E7EE0", Offset = "0x27E64E0", VA = "0x1827E7EE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700011F")]
		public ObiNativeVector4List restPositions
		{
			[Token(Token = "0x600080A")]
			[Address(RVA = "0x27E7F90", Offset = "0x27E6590", VA = "0x1827E7F90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600080B RID: 2059 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000120")]
		public ObiNativeVector4List prevPositions
		{
			[Token(Token = "0x600080B")]
			[Address(RVA = "0x27E8040", Offset = "0x27E6640", VA = "0x1827E8040")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600080C RID: 2060 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000121")]
		public ObiNativeVector4List startPositions
		{
			[Token(Token = "0x600080C")]
			[Address(RVA = "0x27E80F0", Offset = "0x27E66F0", VA = "0x1827E80F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600080D RID: 2061 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000122")]
		public ObiNativeVector4List renderablePositions
		{
			[Token(Token = "0x600080D")]
			[Address(RVA = "0x27E81A0", Offset = "0x27E67A0", VA = "0x1827E81A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000123")]
		public ObiNativeQuaternionList orientations
		{
			[Token(Token = "0x600080E")]
			[Address(RVA = "0x27E8250", Offset = "0x27E6850", VA = "0x1827E8250")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600080F RID: 2063 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000124")]
		public ObiNativeQuaternionList restOrientations
		{
			[Token(Token = "0x600080F")]
			[Address(RVA = "0x27E8300", Offset = "0x27E6900", VA = "0x1827E8300")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000125")]
		public ObiNativeQuaternionList prevOrientations
		{
			[Token(Token = "0x6000810")]
			[Address(RVA = "0x27E83B0", Offset = "0x27E69B0", VA = "0x1827E83B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x06000811 RID: 2065 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000126")]
		public ObiNativeQuaternionList startOrientations
		{
			[Token(Token = "0x6000811")]
			[Address(RVA = "0x27E8460", Offset = "0x27E6A60", VA = "0x1827E8460")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000127")]
		public ObiNativeQuaternionList renderableOrientations
		{
			[Token(Token = "0x6000812")]
			[Address(RVA = "0x27E8510", Offset = "0x27E6B10", VA = "0x1827E8510")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06000813 RID: 2067 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000128")]
		public ObiNativeVector4List velocities
		{
			[Token(Token = "0x6000813")]
			[Address(RVA = "0x27E85C0", Offset = "0x27E6BC0", VA = "0x1827E85C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000129")]
		public ObiNativeVector4List angularVelocities
		{
			[Token(Token = "0x6000814")]
			[Address(RVA = "0x27E8670", Offset = "0x27E6C70", VA = "0x1827E8670")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700012A")]
		public ObiNativeFloatList invMasses
		{
			[Token(Token = "0x6000815")]
			[Address(RVA = "0x27E8720", Offset = "0x27E6D20", VA = "0x1827E8720")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x06000816 RID: 2070 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700012B")]
		public ObiNativeFloatList invRotationalMasses
		{
			[Token(Token = "0x6000816")]
			[Address(RVA = "0x27E87D0", Offset = "0x27E6DD0", VA = "0x1827E87D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06000817 RID: 2071 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700012C")]
		public ObiNativeVector4List invInertiaTensors
		{
			[Token(Token = "0x6000817")]
			[Address(RVA = "0x27E8880", Offset = "0x27E6E80", VA = "0x1827E8880")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06000818 RID: 2072 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700012D")]
		public ObiNativeVector4List externalForces
		{
			[Token(Token = "0x6000818")]
			[Address(RVA = "0x27E8930", Offset = "0x27E6F30", VA = "0x1827E8930")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000819 RID: 2073 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700012E")]
		public ObiNativeVector4List externalTorques
		{
			[Token(Token = "0x6000819")]
			[Address(RVA = "0x27E89E0", Offset = "0x27E6FE0", VA = "0x1827E89E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x0600081A RID: 2074 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700012F")]
		public ObiNativeVector4List wind
		{
			[Token(Token = "0x600081A")]
			[Address(RVA = "0x27E8A90", Offset = "0x27E7090", VA = "0x1827E8A90")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x0600081B RID: 2075 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000130")]
		public ObiNativeVector4List positionDeltas
		{
			[Token(Token = "0x600081B")]
			[Address(RVA = "0x27E8B40", Offset = "0x27E7140", VA = "0x1827E8B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600081C RID: 2076 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000131")]
		public ObiNativeQuaternionList orientationDeltas
		{
			[Token(Token = "0x600081C")]
			[Address(RVA = "0x27E8BF0", Offset = "0x27E71F0", VA = "0x1827E8BF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600081D RID: 2077 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000132")]
		public ObiNativeIntList positionConstraintCounts
		{
			[Token(Token = "0x600081D")]
			[Address(RVA = "0x27E8CC0", Offset = "0x27E72C0", VA = "0x1827E8CC0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000133")]
		public ObiNativeIntList orientationConstraintCounts
		{
			[Token(Token = "0x600081E")]
			[Address(RVA = "0x27E8D70", Offset = "0x27E7370", VA = "0x1827E8D70")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000134")]
		public ObiNativeIntList collisionMaterials
		{
			[Token(Token = "0x600081F")]
			[Address(RVA = "0x27E8E20", Offset = "0x27E7420", VA = "0x1827E8E20")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000135")]
		public ObiNativeIntList phases
		{
			[Token(Token = "0x6000820")]
			[Address(RVA = "0x27E8ED0", Offset = "0x27E74D0", VA = "0x1827E8ED0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x06000821 RID: 2081 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000136")]
		public ObiNativeVector4List anisotropies
		{
			[Token(Token = "0x6000821")]
			[Address(RVA = "0x27E8F80", Offset = "0x27E7580", VA = "0x1827E8F80")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000137")]
		public ObiNativeVector4List principalRadii
		{
			[Token(Token = "0x6000822")]
			[Address(RVA = "0x27E9030", Offset = "0x27E7630", VA = "0x1827E9030")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x06000823 RID: 2083 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000138")]
		public ObiNativeVector4List normals
		{
			[Token(Token = "0x6000823")]
			[Address(RVA = "0x27E90E0", Offset = "0x27E76E0", VA = "0x1827E90E0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000139")]
		public ObiNativeVector4List vorticities
		{
			[Token(Token = "0x6000824")]
			[Address(RVA = "0x27E9190", Offset = "0x27E7790", VA = "0x1827E9190")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700013A")]
		public ObiNativeVector4List fluidData
		{
			[Token(Token = "0x6000825")]
			[Address(RVA = "0x27E9240", Offset = "0x27E7840", VA = "0x1827E9240")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700013B")]
		public ObiNativeVector4List userData
		{
			[Token(Token = "0x6000826")]
			[Address(RVA = "0x27E92F0", Offset = "0x27E78F0", VA = "0x1827E92F0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700013C")]
		public ObiNativeFloatList smoothingRadii
		{
			[Token(Token = "0x6000827")]
			[Address(RVA = "0x27E93A0", Offset = "0x27E79A0", VA = "0x1827E93A0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700013D")]
		public ObiNativeFloatList buoyancies
		{
			[Token(Token = "0x6000828")]
			[Address(RVA = "0x27E9450", Offset = "0x27E7A50", VA = "0x1827E9450")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x06000829 RID: 2089 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700013E")]
		public ObiNativeFloatList restDensities
		{
			[Token(Token = "0x6000829")]
			[Address(RVA = "0x27E9500", Offset = "0x27E7B00", VA = "0x1827E9500")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700013F")]
		public ObiNativeFloatList viscosities
		{
			[Token(Token = "0x600082A")]
			[Address(RVA = "0x27E95B0", Offset = "0x27E7BB0", VA = "0x1827E95B0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600082B RID: 2091 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000140")]
		public ObiNativeFloatList surfaceTension
		{
			[Token(Token = "0x600082B")]
			[Address(RVA = "0x27E9660", Offset = "0x27E7C60", VA = "0x1827E9660")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000141")]
		public ObiNativeFloatList vortConfinement
		{
			[Token(Token = "0x600082C")]
			[Address(RVA = "0x27E9710", Offset = "0x27E7D10", VA = "0x1827E9710")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600082D RID: 2093 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000142")]
		public ObiNativeFloatList atmosphericDrag
		{
			[Token(Token = "0x600082D")]
			[Address(RVA = "0x27E97C0", Offset = "0x27E7DC0", VA = "0x1827E97C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000143")]
		public ObiNativeFloatList atmosphericPressure
		{
			[Token(Token = "0x600082E")]
			[Address(RVA = "0x27E9870", Offset = "0x27E7E70", VA = "0x1827E9870")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600082F RID: 2095 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000144")]
		public ObiNativeFloatList diffusion
		{
			[Token(Token = "0x600082F")]
			[Address(RVA = "0x27E9920", Offset = "0x27E7F20", VA = "0x1827E9920")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000830")]
		[Address(RVA = "0x27E99D0", Offset = "0x27E7FD0", VA = "0x1827E99D0")]
		private void Update()
		{
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000831")]
		[Address(RVA = "0x27E9CB0", Offset = "0x27E82B0", VA = "0x1827E9CB0")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000832")]
		[Address(RVA = "0x27E9D60", Offset = "0x27E8360", VA = "0x1827E9D60")]
		private void CreateBackend()
		{
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000833")]
		[Address(RVA = "0x27E9ED0", Offset = "0x27E84D0", VA = "0x1827E9ED0")]
		public void Initialize()
		{
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00004994 File Offset: 0x00002B94
		[Token(Token = "0x6000834")]
		[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70")]
		internal static bool IsPrefabStageOrPreview(GameObject gameObject)
		{
			return default(bool);
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000835")]
		[Address(RVA = "0x27EAB10", Offset = "0x27E9110", VA = "0x1827EAB10")]
		public void Teardown()
		{
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000836")]
		[Address(RVA = "0x27EAD20", Offset = "0x27E9320", VA = "0x1827EAD20")]
		public void UpdateBackend()
		{
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000837")]
		[Address(RVA = "0x27EAFB0", Offset = "0x27E95B0", VA = "0x1827EAFB0")]
		private void FreeRigidbodyArrays()
		{
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000838")]
		[Address(RVA = "0x27EB0D0", Offset = "0x27E96D0", VA = "0x1827EB0D0")]
		public void EnsureRigidbodyArraysCapacity(int count)
		{
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000839")]
		[Address(RVA = "0x27EB1C0", Offset = "0x27E97C0", VA = "0x1827EB1C0")]
		private void FreeParticleArrays()
		{
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600083A")]
		[Address(RVA = "0x27EC340", Offset = "0x27EA940", VA = "0x1827EC340")]
		private void EnsureParticleArraysCapacity(int count)
		{
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600083B")]
		[Address(RVA = "0x27ECF10", Offset = "0x27EB510", VA = "0x1827ECF10")]
		private void AllocateParticles(int[] particleIndices)
		{
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600083C")]
		[Address(RVA = "0x27ED1E0", Offset = "0x27EB7E0", VA = "0x1827ED1E0")]
		private void FreeParticles(int[] particleIndices)
		{
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x000049AC File Offset: 0x00002BAC
		[Token(Token = "0x600083D")]
		[Address(RVA = "0x27ED240", Offset = "0x27EB840", VA = "0x1827ED240")]
		public bool AddActor(ObiActor actor)
		{
			return default(bool);
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x000049C4 File Offset: 0x00002BC4
		[Token(Token = "0x600083E")]
		[Address(RVA = "0x27ED770", Offset = "0x27EBD70", VA = "0x1827ED770")]
		public bool RemoveActor(ObiActor actor)
		{
			return default(bool);
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600083F")]
		[Address(RVA = "0x27EDAD0", Offset = "0x27EC0D0", VA = "0x1827EDAD0")]
		public void PushSolverParameters()
		{
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000049DC File Offset: 0x00002BDC
		[Token(Token = "0x6000840")]
		[Address(RVA = "0x27EDE60", Offset = "0x27EC460", VA = "0x1827EDE60")]
		public Oni.ConstraintParameters GetConstraintParameters(Oni.ConstraintType constraintType)
		{
			return default(Oni.ConstraintParameters);
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000841")]
		[Address(RVA = "0x27EDFD0", Offset = "0x27EC5D0", VA = "0x1827EDFD0")]
		public IObiConstraints GetConstraintsByType(Oni.ConstraintType type)
		{
			return null;
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000842")]
		[Address(RVA = "0x27EE010", Offset = "0x27EC610", VA = "0x1827EE010")]
		private void PushActiveParticles()
		{
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000843")]
		[Address(RVA = "0x27EE1D0", Offset = "0x27EC7D0", VA = "0x1827EE1D0")]
		private void PushSimplices()
		{
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000844")]
		[Address(RVA = "0x27EEBD0", Offset = "0x27ED1D0", VA = "0x1827EEBD0")]
		private void PushConstraints()
		{
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000845")]
		[Address(RVA = "0x27EEE70", Offset = "0x27ED470", VA = "0x1827EEE70")]
		private void UpdateVisibility()
		{
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000846")]
		[Address(RVA = "0x27EFB60", Offset = "0x27EE160", VA = "0x1827EFB60")]
		private void InitializeTransformFrame()
		{
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000847")]
		[Address(RVA = "0x27EFE90", Offset = "0x27EE490", VA = "0x1827EFE90")]
		private void UpdateTransformFrame(float dt)
		{
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000848")]
		[Address(RVA = "0x27F02C0", Offset = "0x27EE8C0", VA = "0x1827F02C0")]
		public IObiJobHandle BeginStep(float stepTime)
		{
			return null;
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000849")]
		[Address(RVA = "0x27F08C0", Offset = "0x27EEEC0", VA = "0x1827F08C0")]
		public IObiJobHandle Substep(float stepTime, float substepTime, int index)
		{
			return null;
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600084A")]
		[Address(RVA = "0x27F0BA0", Offset = "0x27EF1A0", VA = "0x1827F0BA0")]
		public void EndStep(float substepTime)
		{
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600084B")]
		[Address(RVA = "0x27F0EF0", Offset = "0x27EF4F0", VA = "0x1827F0EF0")]
		public void Interpolate(float stepTime, float unsimulatedTime)
		{
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600084C")]
		[Address(RVA = "0x27F1270", Offset = "0x27EF870", VA = "0x1827F1270")]
		public ObiSolver()
		{
		}

		// Token: 0x040006AE RID: 1710
		[Token(Token = "0x40006AE")]
		[FieldOffset(Offset = "0x0")]
		private static ProfilerMarker m_StateInterpolationPerfMarker;

		// Token: 0x040006AF RID: 1711
		[Token(Token = "0x40006AF")]
		[FieldOffset(Offset = "0x8")]
		private static ProfilerMarker m_UpdateVisibilityPerfMarker;

		// Token: 0x040006B0 RID: 1712
		[Token(Token = "0x40006B0")]
		[FieldOffset(Offset = "0x10")]
		private static ProfilerMarker m_GetSolverBoundsPerfMarker;

		// Token: 0x040006B1 RID: 1713
		[Token(Token = "0x40006B1")]
		[FieldOffset(Offset = "0x18")]
		private static ProfilerMarker m_TestBoundsPerfMarker;

		// Token: 0x040006B2 RID: 1714
		[Token(Token = "0x40006B2")]
		[FieldOffset(Offset = "0x20")]
		private static ProfilerMarker m_GetAllCamerasPerfMarker;

		// Token: 0x040006BB RID: 1723
		[Token(Token = "0x40006BB")]
		[FieldOffset(Offset = "0x60")]
		[Tooltip("If enabled, will force the solver to keep simulating even when not visible from any camera.")]
		public bool simulateWhenInvisible;

		// Token: 0x040006BC RID: 1724
		[Token(Token = "0x40006BC")]
		[FieldOffset(Offset = "0x68")]
		private ISolverImpl m_SolverImpl;

		// Token: 0x040006BD RID: 1725
		[Token(Token = "0x40006BD")]
		[FieldOffset(Offset = "0x70")]
		private IObiBackend m_SimulationBackend;

		// Token: 0x040006BE RID: 1726
		[Token(Token = "0x40006BE")]
		[FieldOffset(Offset = "0x78")]
		[SerializeField]
		private ObiSolver.BackendType m_Backend;

		// Token: 0x040006BF RID: 1727
		[Token(Token = "0x40006BF")]
		[FieldOffset(Offset = "0x7C")]
		[ChildrenOnly]
		public Oni.SolverParameters parameters;

		// Token: 0x040006C0 RID: 1728
		[Token(Token = "0x40006C0")]
		[FieldOffset(Offset = "0xB4")]
		[Range(0f, 1f)]
		public float worldLinearInertiaScale;

		// Token: 0x040006C1 RID: 1729
		[Token(Token = "0x40006C1")]
		[FieldOffset(Offset = "0xB8")]
		[Range(0f, 1f)]
		public float worldAngularInertiaScale;

		// Token: 0x040006C2 RID: 1730
		[Token(Token = "0x40006C2")]
		[FieldOffset(Offset = "0xC0")]
		[HideInInspector]
		[NonSerialized]
		public List<ObiActor> actors;

		// Token: 0x040006C3 RID: 1731
		[Token(Token = "0x40006C3")]
		[FieldOffset(Offset = "0xC8")]
		[HideInInspector]
		[NonSerialized]
		public ObiSolver.ParticleInActor[] m_ParticleToActor;

		// Token: 0x040006C4 RID: 1732
		[Token(Token = "0x40006C4")]
		[FieldOffset(Offset = "0xD0")]
		private ObiNativeIntList freeList;

		// Token: 0x040006C5 RID: 1733
		[Token(Token = "0x40006C5")]
		[FieldOffset(Offset = "0xD8")]
		private int[] activeParticles;

		// Token: 0x040006C6 RID: 1734
		[Token(Token = "0x40006C6")]
		[FieldOffset(Offset = "0xE0")]
		private int activeParticleCount;

		// Token: 0x040006C7 RID: 1735
		[Token(Token = "0x40006C7")]
		[FieldOffset(Offset = "0xE8")]
		[NonSerialized]
		public List<int> simplices;

		// Token: 0x040006C8 RID: 1736
		[Token(Token = "0x40006C8")]
		[FieldOffset(Offset = "0xF0")]
		private List<int> points;

		// Token: 0x040006C9 RID: 1737
		[Token(Token = "0x40006C9")]
		[FieldOffset(Offset = "0xF8")]
		private List<int> edges;

		// Token: 0x040006CA RID: 1738
		[Token(Token = "0x40006CA")]
		[FieldOffset(Offset = "0x100")]
		private List<int> triangles;

		// Token: 0x040006CB RID: 1739
		[Token(Token = "0x40006CB")]
		[FieldOffset(Offset = "0x108")]
		private SimplexCounts m_SimplexCounts;

		// Token: 0x040006CC RID: 1740
		[Token(Token = "0x40006CC")]
		[FieldOffset(Offset = "0x114")]
		[HideInInspector]
		[NonSerialized]
		public bool dirtyActiveParticles;

		// Token: 0x040006CD RID: 1741
		[Token(Token = "0x40006CD")]
		[FieldOffset(Offset = "0x115")]
		[HideInInspector]
		[NonSerialized]
		public bool dirtySimplices;

		// Token: 0x040006CE RID: 1742
		[Token(Token = "0x40006CE")]
		[FieldOffset(Offset = "0x118")]
		[HideInInspector]
		[NonSerialized]
		public int dirtyConstraints;

		// Token: 0x040006CF RID: 1743
		[Token(Token = "0x40006CF")]
		[FieldOffset(Offset = "0x120")]
		private ObiSolver.ObiCollisionEventArgs collisionArgs;

		// Token: 0x040006D0 RID: 1744
		[Token(Token = "0x40006D0")]
		[FieldOffset(Offset = "0x128")]
		private ObiSolver.ObiCollisionEventArgs particleCollisionArgs;

		// Token: 0x040006D1 RID: 1745
		[Token(Token = "0x40006D1")]
		[FieldOffset(Offset = "0x130")]
		private int m_contactCount;

		// Token: 0x040006D2 RID: 1746
		[Token(Token = "0x40006D2")]
		[FieldOffset(Offset = "0x134")]
		private int m_particleContactCount;

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0x138")]
		private float m_MaxScale;

		// Token: 0x040006D4 RID: 1748
		[Token(Token = "0x40006D4")]
		[FieldOffset(Offset = "0x13C")]
		private Bounds bounds;

		// Token: 0x040006D5 RID: 1749
		[Token(Token = "0x40006D5")]
		[FieldOffset(Offset = "0x158")]
		private Plane[] planes;

		// Token: 0x040006D6 RID: 1750
		[Token(Token = "0x40006D6")]
		[FieldOffset(Offset = "0x160")]
		private Camera[] sceneCameras;

		// Token: 0x040006D7 RID: 1751
		[Token(Token = "0x40006D7")]
		[FieldOffset(Offset = "0x168")]
		private bool isVisible;

		// Token: 0x040006D8 RID: 1752
		[Token(Token = "0x40006D8")]
		[FieldOffset(Offset = "0x170")]
		[NonSerialized]
		private IObiConstraints[] m_Constraints;

		// Token: 0x040006D9 RID: 1753
		[Token(Token = "0x40006D9")]
		[FieldOffset(Offset = "0x178")]
		public Oni.ConstraintParameters distanceConstraintParameters;

		// Token: 0x040006DA RID: 1754
		[Token(Token = "0x40006DA")]
		[FieldOffset(Offset = "0x188")]
		public Oni.ConstraintParameters bendingConstraintParameters;

		// Token: 0x040006DB RID: 1755
		[Token(Token = "0x40006DB")]
		[FieldOffset(Offset = "0x198")]
		public Oni.ConstraintParameters particleCollisionConstraintParameters;

		// Token: 0x040006DC RID: 1756
		[Token(Token = "0x40006DC")]
		[FieldOffset(Offset = "0x1A8")]
		public Oni.ConstraintParameters particleFrictionConstraintParameters;

		// Token: 0x040006DD RID: 1757
		[Token(Token = "0x40006DD")]
		[FieldOffset(Offset = "0x1B8")]
		public Oni.ConstraintParameters collisionConstraintParameters;

		// Token: 0x040006DE RID: 1758
		[Token(Token = "0x40006DE")]
		[FieldOffset(Offset = "0x1C8")]
		public Oni.ConstraintParameters frictionConstraintParameters;

		// Token: 0x040006DF RID: 1759
		[Token(Token = "0x40006DF")]
		[FieldOffset(Offset = "0x1D8")]
		public Oni.ConstraintParameters skinConstraintParameters;

		// Token: 0x040006E0 RID: 1760
		[Token(Token = "0x40006E0")]
		[FieldOffset(Offset = "0x1E8")]
		public Oni.ConstraintParameters volumeConstraintParameters;

		// Token: 0x040006E1 RID: 1761
		[Token(Token = "0x40006E1")]
		[FieldOffset(Offset = "0x1F8")]
		public Oni.ConstraintParameters shapeMatchingConstraintParameters;

		// Token: 0x040006E2 RID: 1762
		[Token(Token = "0x40006E2")]
		[FieldOffset(Offset = "0x208")]
		public Oni.ConstraintParameters tetherConstraintParameters;

		// Token: 0x040006E3 RID: 1763
		[Token(Token = "0x40006E3")]
		[FieldOffset(Offset = "0x218")]
		public Oni.ConstraintParameters pinConstraintParameters;

		// Token: 0x040006E4 RID: 1764
		[Token(Token = "0x40006E4")]
		[FieldOffset(Offset = "0x228")]
		public Oni.ConstraintParameters stitchConstraintParameters;

		// Token: 0x040006E5 RID: 1765
		[Token(Token = "0x40006E5")]
		[FieldOffset(Offset = "0x238")]
		public Oni.ConstraintParameters densityConstraintParameters;

		// Token: 0x040006E6 RID: 1766
		[Token(Token = "0x40006E6")]
		[FieldOffset(Offset = "0x248")]
		public Oni.ConstraintParameters stretchShearConstraintParameters;

		// Token: 0x040006E7 RID: 1767
		[Token(Token = "0x40006E7")]
		[FieldOffset(Offset = "0x258")]
		public Oni.ConstraintParameters bendTwistConstraintParameters;

		// Token: 0x040006E8 RID: 1768
		[Token(Token = "0x40006E8")]
		[FieldOffset(Offset = "0x268")]
		public Oni.ConstraintParameters chainConstraintParameters;

		// Token: 0x040006E9 RID: 1769
		[Token(Token = "0x40006E9")]
		[FieldOffset(Offset = "0x278")]
		private ObiNativeVector4List m_RigidbodyLinearVelocities;

		// Token: 0x040006EA RID: 1770
		[Token(Token = "0x40006EA")]
		[FieldOffset(Offset = "0x280")]
		private ObiNativeVector4List m_RigidbodyAngularVelocities;

		// Token: 0x040006EB RID: 1771
		[Token(Token = "0x40006EB")]
		[FieldOffset(Offset = "0x288")]
		[NonSerialized]
		private Color[] m_Colors;

		// Token: 0x040006EC RID: 1772
		[Token(Token = "0x40006EC")]
		[FieldOffset(Offset = "0x290")]
		[NonSerialized]
		private ObiNativeInt4List m_CellCoords;

		// Token: 0x040006ED RID: 1773
		[Token(Token = "0x40006ED")]
		[FieldOffset(Offset = "0x298")]
		[NonSerialized]
		private ObiNativeVector4List m_Positions;

		// Token: 0x040006EE RID: 1774
		[Token(Token = "0x40006EE")]
		[FieldOffset(Offset = "0x2A0")]
		[NonSerialized]
		private ObiNativeVector4List m_RestPositions;

		// Token: 0x040006EF RID: 1775
		[Token(Token = "0x40006EF")]
		[FieldOffset(Offset = "0x2A8")]
		[NonSerialized]
		private ObiNativeVector4List m_PrevPositions;

		// Token: 0x040006F0 RID: 1776
		[Token(Token = "0x40006F0")]
		[FieldOffset(Offset = "0x2B0")]
		[NonSerialized]
		private ObiNativeVector4List m_StartPositions;

		// Token: 0x040006F1 RID: 1777
		[Token(Token = "0x40006F1")]
		[FieldOffset(Offset = "0x2B8")]
		[NonSerialized]
		private ObiNativeVector4List m_RenderablePositions;

		// Token: 0x040006F2 RID: 1778
		[Token(Token = "0x40006F2")]
		[FieldOffset(Offset = "0x2C0")]
		[NonSerialized]
		private ObiNativeQuaternionList m_Orientations;

		// Token: 0x040006F3 RID: 1779
		[Token(Token = "0x40006F3")]
		[FieldOffset(Offset = "0x2C8")]
		[NonSerialized]
		private ObiNativeQuaternionList m_RestOrientations;

		// Token: 0x040006F4 RID: 1780
		[Token(Token = "0x40006F4")]
		[FieldOffset(Offset = "0x2D0")]
		[NonSerialized]
		private ObiNativeQuaternionList m_PrevOrientations;

		// Token: 0x040006F5 RID: 1781
		[Token(Token = "0x40006F5")]
		[FieldOffset(Offset = "0x2D8")]
		[NonSerialized]
		private ObiNativeQuaternionList m_StartOrientations;

		// Token: 0x040006F6 RID: 1782
		[Token(Token = "0x40006F6")]
		[FieldOffset(Offset = "0x2E0")]
		[NonSerialized]
		private ObiNativeQuaternionList m_RenderableOrientations;

		// Token: 0x040006F7 RID: 1783
		[Token(Token = "0x40006F7")]
		[FieldOffset(Offset = "0x2E8")]
		[NonSerialized]
		private ObiNativeVector4List m_Velocities;

		// Token: 0x040006F8 RID: 1784
		[Token(Token = "0x40006F8")]
		[FieldOffset(Offset = "0x2F0")]
		[NonSerialized]
		private ObiNativeVector4List m_AngularVelocities;

		// Token: 0x040006F9 RID: 1785
		[Token(Token = "0x40006F9")]
		[FieldOffset(Offset = "0x2F8")]
		[NonSerialized]
		private ObiNativeFloatList m_InvMasses;

		// Token: 0x040006FA RID: 1786
		[Token(Token = "0x40006FA")]
		[FieldOffset(Offset = "0x300")]
		[NonSerialized]
		private ObiNativeFloatList m_InvRotationalMasses;

		// Token: 0x040006FB RID: 1787
		[Token(Token = "0x40006FB")]
		[FieldOffset(Offset = "0x308")]
		[NonSerialized]
		private ObiNativeVector4List m_InvInertiaTensors;

		// Token: 0x040006FC RID: 1788
		[Token(Token = "0x40006FC")]
		[FieldOffset(Offset = "0x310")]
		[NonSerialized]
		private ObiNativeVector4List m_ExternalForces;

		// Token: 0x040006FD RID: 1789
		[Token(Token = "0x40006FD")]
		[FieldOffset(Offset = "0x318")]
		[NonSerialized]
		private ObiNativeVector4List m_ExternalTorques;

		// Token: 0x040006FE RID: 1790
		[Token(Token = "0x40006FE")]
		[FieldOffset(Offset = "0x320")]
		[NonSerialized]
		private ObiNativeVector4List m_Wind;

		// Token: 0x040006FF RID: 1791
		[Token(Token = "0x40006FF")]
		[FieldOffset(Offset = "0x328")]
		[NonSerialized]
		private ObiNativeVector4List m_PositionDeltas;

		// Token: 0x04000700 RID: 1792
		[Token(Token = "0x4000700")]
		[FieldOffset(Offset = "0x330")]
		[NonSerialized]
		private ObiNativeQuaternionList m_OrientationDeltas;

		// Token: 0x04000701 RID: 1793
		[Token(Token = "0x4000701")]
		[FieldOffset(Offset = "0x338")]
		[NonSerialized]
		private ObiNativeIntList m_PositionConstraintCounts;

		// Token: 0x04000702 RID: 1794
		[Token(Token = "0x4000702")]
		[FieldOffset(Offset = "0x340")]
		[NonSerialized]
		private ObiNativeIntList m_OrientationConstraintCounts;

		// Token: 0x04000703 RID: 1795
		[Token(Token = "0x4000703")]
		[FieldOffset(Offset = "0x348")]
		[NonSerialized]
		private ObiNativeIntList m_CollisionMaterials;

		// Token: 0x04000704 RID: 1796
		[Token(Token = "0x4000704")]
		[FieldOffset(Offset = "0x350")]
		[NonSerialized]
		private ObiNativeIntList m_Phases;

		// Token: 0x04000705 RID: 1797
		[Token(Token = "0x4000705")]
		[FieldOffset(Offset = "0x358")]
		[NonSerialized]
		private ObiNativeVector4List m_Anisotropies;

		// Token: 0x04000706 RID: 1798
		[Token(Token = "0x4000706")]
		[FieldOffset(Offset = "0x360")]
		[NonSerialized]
		private ObiNativeVector4List m_PrincipalRadii;

		// Token: 0x04000707 RID: 1799
		[Token(Token = "0x4000707")]
		[FieldOffset(Offset = "0x368")]
		[NonSerialized]
		private ObiNativeVector4List m_Normals;

		// Token: 0x04000708 RID: 1800
		[Token(Token = "0x4000708")]
		[FieldOffset(Offset = "0x370")]
		[NonSerialized]
		private ObiNativeVector4List m_Vorticities;

		// Token: 0x04000709 RID: 1801
		[Token(Token = "0x4000709")]
		[FieldOffset(Offset = "0x378")]
		[NonSerialized]
		private ObiNativeVector4List m_FluidData;

		// Token: 0x0400070A RID: 1802
		[Token(Token = "0x400070A")]
		[FieldOffset(Offset = "0x380")]
		[NonSerialized]
		private ObiNativeVector4List m_UserData;

		// Token: 0x0400070B RID: 1803
		[Token(Token = "0x400070B")]
		[FieldOffset(Offset = "0x388")]
		[NonSerialized]
		private ObiNativeFloatList m_SmoothingRadii;

		// Token: 0x0400070C RID: 1804
		[Token(Token = "0x400070C")]
		[FieldOffset(Offset = "0x390")]
		[NonSerialized]
		private ObiNativeFloatList m_Buoyancies;

		// Token: 0x0400070D RID: 1805
		[Token(Token = "0x400070D")]
		[FieldOffset(Offset = "0x398")]
		[NonSerialized]
		private ObiNativeFloatList m_RestDensities;

		// Token: 0x0400070E RID: 1806
		[Token(Token = "0x400070E")]
		[FieldOffset(Offset = "0x3A0")]
		[NonSerialized]
		private ObiNativeFloatList m_Viscosities;

		// Token: 0x0400070F RID: 1807
		[Token(Token = "0x400070F")]
		[FieldOffset(Offset = "0x3A8")]
		[NonSerialized]
		private ObiNativeFloatList m_SurfaceTension;

		// Token: 0x04000710 RID: 1808
		[Token(Token = "0x4000710")]
		[FieldOffset(Offset = "0x3B0")]
		[NonSerialized]
		private ObiNativeFloatList m_VortConfinement;

		// Token: 0x04000711 RID: 1809
		[Token(Token = "0x4000711")]
		[FieldOffset(Offset = "0x3B8")]
		[NonSerialized]
		private ObiNativeFloatList m_AtmosphericDrag;

		// Token: 0x04000712 RID: 1810
		[Token(Token = "0x4000712")]
		[FieldOffset(Offset = "0x3C0")]
		[NonSerialized]
		private ObiNativeFloatList m_AtmosphericPressure;

		// Token: 0x04000713 RID: 1811
		[Token(Token = "0x4000713")]
		[FieldOffset(Offset = "0x3C8")]
		[NonSerialized]
		private ObiNativeFloatList m_Diffusion;

		// Token: 0x020001A5 RID: 421
		[Token(Token = "0x20001A5")]
		public enum BackendType
		{
			// Token: 0x04000715 RID: 1813
			[Token(Token = "0x4000715")]
			Oni,
			// Token: 0x04000716 RID: 1814
			[Token(Token = "0x4000716")]
			Burst
		}

		// Token: 0x020001A6 RID: 422
		[Token(Token = "0x20001A6")]
		public class ObiCollisionEventArgs : EventArgs
		{
			// Token: 0x0600084E RID: 2126 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600084E")]
			[Address(RVA = "0x27F1D80", Offset = "0x27F0380", VA = "0x1827F1D80")]
			public ObiCollisionEventArgs()
			{
			}

			// Token: 0x04000717 RID: 1815
			[Token(Token = "0x4000717")]
			[FieldOffset(Offset = "0x10")]
			public ObiList<Oni.Contact> contacts;
		}

		// Token: 0x020001A7 RID: 423
		[Token(Token = "0x20001A7")]
		[Serializable]
		public class ParticleInActor
		{
			// Token: 0x0600084F RID: 2127 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x600084F")]
			[Address(RVA = "0x27F1ED0", Offset = "0x27F04D0", VA = "0x1827F1ED0")]
			public ParticleInActor()
			{
			}

			// Token: 0x06000850 RID: 2128 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000850")]
			[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
			public ParticleInActor(ObiActor actor, int indexInActor)
			{
			}

			// Token: 0x04000718 RID: 1816
			[Token(Token = "0x4000718")]
			[FieldOffset(Offset = "0x10")]
			public ObiActor actor;

			// Token: 0x04000719 RID: 1817
			[Token(Token = "0x4000719")]
			[FieldOffset(Offset = "0x18")]
			public int indexInActor;
		}

		// Token: 0x020001A8 RID: 424
		// (Invoke) Token: 0x06000852 RID: 2130
		[Token(Token = "0x20001A8")]
		public delegate void SolverCallback(ObiSolver solver);

		// Token: 0x020001A9 RID: 425
		// (Invoke) Token: 0x06000856 RID: 2134
		[Token(Token = "0x20001A9")]
		public delegate void SolverStepCallback(ObiSolver solver, float stepTime);

		// Token: 0x020001AA RID: 426
		// (Invoke) Token: 0x0600085A RID: 2138
		[Token(Token = "0x20001AA")]
		public delegate void CollisionCallback(ObiSolver solver, ObiSolver.ObiCollisionEventArgs contacts);
	}
}
