using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001D4 RID: 468
	[Token(Token = "0x20001D4")]
	[ExecuteInEditMode]
	[AddComponentMenu("Physics/Obi/Obi Rope", 880)]
	[DisallowMultipleComponent]
	public class ObiRope : ObiRopeBase, IDistanceConstraintsUser, IBendConstraintsUser
	{
		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x00004F64 File Offset: 0x00003164
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700016E")]
		public bool selfCollisions
		{
			[Token(Token = "0x6000960")]
			[Address(RVA = "0x26093E0", Offset = "0x26079E0", VA = "0x1826093E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000961")]
			[Address(RVA = "0x2739840", Offset = "0x2737E40", VA = "0x182739840")]
			set
			{
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00004F7C File Offset: 0x0000317C
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700016F")]
		public bool distanceConstraintsEnabled
		{
			[Token(Token = "0x6000962")]
			[Address(RVA = "0x28068F0", Offset = "0x2804EF0", VA = "0x1828068F0", Slot = "38")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000963")]
			[Address(RVA = "0x2806900", Offset = "0x2804F00", VA = "0x182806900", Slot = "39")]
			set
			{
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000964 RID: 2404 RVA: 0x00004F94 File Offset: 0x00003194
		// (set) Token: 0x06000965 RID: 2405 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000170")]
		public float stretchingScale
		{
			[Token(Token = "0x6000964")]
			[Address(RVA = "0x13429E0", Offset = "0x1340FE0", VA = "0x1813429E0", Slot = "40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000965")]
			[Address(RVA = "0x2806920", Offset = "0x2804F20", VA = "0x182806920", Slot = "41")]
			set
			{
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000966 RID: 2406 RVA: 0x00004FAC File Offset: 0x000031AC
		// (set) Token: 0x06000967 RID: 2407 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000171")]
		public float stretchCompliance
		{
			[Token(Token = "0x6000966")]
			[Address(RVA = "0x2805FC0", Offset = "0x28045C0", VA = "0x182805FC0", Slot = "42")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000967")]
			[Address(RVA = "0x2806940", Offset = "0x2804F40", VA = "0x182806940", Slot = "43")]
			set
			{
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000968 RID: 2408 RVA: 0x00004FC4 File Offset: 0x000031C4
		// (set) Token: 0x06000969 RID: 2409 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000172")]
		public float maxCompression
		{
			[Token(Token = "0x6000968")]
			[Address(RVA = "0x1342A00", Offset = "0x1341000", VA = "0x181342A00", Slot = "44")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000969")]
			[Address(RVA = "0x2806960", Offset = "0x2804F60", VA = "0x182806960", Slot = "45")]
			set
			{
			}
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x0600096A RID: 2410 RVA: 0x00004FDC File Offset: 0x000031DC
		// (set) Token: 0x0600096B RID: 2411 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000173")]
		public bool bendConstraintsEnabled
		{
			[Token(Token = "0x600096A")]
			[Address(RVA = "0x2806980", Offset = "0x2804F80", VA = "0x182806980", Slot = "46")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600096B")]
			[Address(RVA = "0x2806990", Offset = "0x2804F90", VA = "0x182806990", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x0600096C RID: 2412 RVA: 0x00004FF4 File Offset: 0x000031F4
		// (set) Token: 0x0600096D RID: 2413 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000174")]
		public float bendCompliance
		{
			[Token(Token = "0x600096C")]
			[Address(RVA = "0x1342C10", Offset = "0x1341210", VA = "0x181342C10", Slot = "48")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600096D")]
			[Address(RVA = "0x28069B0", Offset = "0x2804FB0", VA = "0x1828069B0", Slot = "49")]
			set
			{
			}
		}

		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x0000500C File Offset: 0x0000320C
		// (set) Token: 0x0600096F RID: 2415 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000175")]
		public float maxBending
		{
			[Token(Token = "0x600096E")]
			[Address(RVA = "0x2806050", Offset = "0x2804650", VA = "0x182806050", Slot = "50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600096F")]
			[Address(RVA = "0x28069D0", Offset = "0x2804FD0", VA = "0x1828069D0", Slot = "51")]
			set
			{
			}
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00005024 File Offset: 0x00003224
		// (set) Token: 0x06000971 RID: 2417 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000176")]
		public float plasticYield
		{
			[Token(Token = "0x6000970")]
			[Address(RVA = "0x2739540", Offset = "0x2737B40", VA = "0x182739540", Slot = "52")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000971")]
			[Address(RVA = "0x28069F0", Offset = "0x2804FF0", VA = "0x1828069F0", Slot = "53")]
			set
			{
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x06000972 RID: 2418 RVA: 0x0000503C File Offset: 0x0000323C
		// (set) Token: 0x06000973 RID: 2419 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000177")]
		public float plasticCreep
		{
			[Token(Token = "0x6000972")]
			[Address(RVA = "0x2739570", Offset = "0x2737B70", VA = "0x182739570", Slot = "54")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000973")]
			[Address(RVA = "0x2806A10", Offset = "0x2805010", VA = "0x182806A10", Slot = "55")]
			set
			{
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x06000974 RID: 2420 RVA: 0x00005054 File Offset: 0x00003254
		[Token(Token = "0x17000178")]
		public float interParticleDistance
		{
			[Token(Token = "0x6000974")]
			[Address(RVA = "0x2806080", Offset = "0x2804680", VA = "0x182806080")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000179")]
		public override ObiActorBlueprint sourceBlueprint
		{
			[Token(Token = "0x6000975")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80", Slot = "17")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x06000976 RID: 2422 RVA: 0x00002186 File Offset: 0x00000386
		// (set) Token: 0x06000977 RID: 2423 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700017A")]
		public ObiRopeBlueprint ropeBlueprint
		{
			[Token(Token = "0x6000976")]
			[Address(RVA = "0x8ECC80", Offset = "0x8EB280", VA = "0x1808ECC80")]
			get
			{
				return null;
			}
			[Token(Token = "0x6000977")]
			[Address(RVA = "0x2806A30", Offset = "0x2805030", VA = "0x182806A30")]
			set
			{
			}
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x06000978 RID: 2424 RVA: 0x000020F6 File Offset: 0x000002F6
		// (remove) Token: 0x06000979 RID: 2425 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x14000013")]
		public event ObiRope.RopeTornCallback OnRopeTorn
		{
			[Token(Token = "0x6000978")]
			[Address(RVA = "0x2806C00", Offset = "0x2805200", VA = "0x182806C00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000979")]
			[Address(RVA = "0x2806CF0", Offset = "0x28052F0", VA = "0x182806CF0")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600097A")]
		[Address(RVA = "0x2806DE0", Offset = "0x28053E0", VA = "0x182806DE0", Slot = "20")]
		protected override void OnValidate()
		{
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600097B")]
		[Address(RVA = "0x2806E40", Offset = "0x2805440", VA = "0x182806E40", Slot = "28")]
		public override void LoadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600097C")]
		[Address(RVA = "0x2807000", Offset = "0x2805600", VA = "0x182807000", Slot = "29")]
		public override void UnloadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600097D")]
		[Address(RVA = "0x2806DE0", Offset = "0x28053E0", VA = "0x182806DE0")]
		private void SetupRuntimeConstraints()
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600097E")]
		[Address(RVA = "0x2807100", Offset = "0x2805700", VA = "0x182807100", Slot = "32")]
		public override void Substep(float substepTime)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x600097F")]
		[Address(RVA = "0x2807190", Offset = "0x2805790", VA = "0x182807190")]
		protected void ApplyTearing(float substepTime)
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x0000506C File Offset: 0x0000326C
		[Token(Token = "0x6000980")]
		[Address(RVA = "0x2807700", Offset = "0x2805D00", VA = "0x182807700")]
		private int SplitParticle(int splitIndex)
		{
			return 0;
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x00005084 File Offset: 0x00003284
		[Token(Token = "0x6000981")]
		[Address(RVA = "0x2807820", Offset = "0x2805E20", VA = "0x182807820")]
		public bool Tear(ObiStructuralElement element)
		{
			return default(bool);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000982")]
		[Address(RVA = "0x2807B40", Offset = "0x2806140", VA = "0x182807B40", Slot = "36")]
		protected override void RebuildElementsFromConstraintsInternal()
		{
		}

		// Token: 0x06000983 RID: 2435 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000983")]
		[Address(RVA = "0x2808010", Offset = "0x2806610", VA = "0x182808010", Slot = "37")]
		public override void RebuildConstraintsFromElements()
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000984")]
		[Address(RVA = "0x2809850", Offset = "0x2807E50", VA = "0x182809850")]
		public ObiRope()
		{
		}

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		protected ObiRopeBlueprint m_RopeBlueprint;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0xC8")]
		private ObiRopeBlueprint m_RopeBlueprintInstance;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0xD0")]
		public bool tearingEnabled;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0xD4")]
		public float tearResistanceMultiplier;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0xD8")]
		public int tearRate;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0xDC")]
		[SerializeField]
		protected bool _distanceConstraintsEnabled;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0xE0")]
		[SerializeField]
		protected float _stretchingScale;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0xE4")]
		[SerializeField]
		protected float _stretchCompliance;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0xE8")]
		[SerializeField]
		[Range(0f, 1f)]
		protected float _maxCompression;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0xEC")]
		[SerializeField]
		protected bool _bendConstraintsEnabled;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0xF0")]
		[SerializeField]
		protected float _bendCompliance;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0xF4")]
		[SerializeField]
		[Range(0f, 0.5f)]
		protected float _maxBending;

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0xF8")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float _plasticYield;

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0xFC")]
		[SerializeField]
		protected float _plasticCreep;

		// Token: 0x020001D5 RID: 469
		// (Invoke) Token: 0x06000986 RID: 2438
		[Token(Token = "0x20001D5")]
		public delegate void RopeTornCallback(ObiRope rope, ObiRope.ObiRopeTornEventArgs tearInfo);

		// Token: 0x020001D6 RID: 470
		[Token(Token = "0x20001D6")]
		public class ObiRopeTornEventArgs
		{
			// Token: 0x06000989 RID: 2441 RVA: 0x000020F6 File Offset: 0x000002F6
			[Token(Token = "0x6000989")]
			[Address(RVA = "0x753680", Offset = "0x751C80", VA = "0x180753680")]
			public ObiRopeTornEventArgs(ObiStructuralElement element, int particle)
			{
			}

			// Token: 0x040007B8 RID: 1976
			[Token(Token = "0x40007B8")]
			[FieldOffset(Offset = "0x10")]
			public ObiStructuralElement element;

			// Token: 0x040007B9 RID: 1977
			[Token(Token = "0x40007B9")]
			[FieldOffset(Offset = "0x18")]
			public int particleIndex;
		}
	}
}
