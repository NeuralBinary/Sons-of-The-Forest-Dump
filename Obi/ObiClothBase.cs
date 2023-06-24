using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x02000017 RID: 23
	[Token(Token = "0x2000017")]
	public abstract class ObiClothBase : ObiActor, IDistanceConstraintsUser, IBendConstraintsUser, IAerodynamicConstraintsUser
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x060000A1 RID: 161
		[Token(Token = "0x1700000B")]
		public abstract ObiClothBlueprintBase clothBlueprintBase { [Token(Token = "0x60000A1")] get; }

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000221C File Offset: 0x0000041C
		// (set) Token: 0x060000A3 RID: 163 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700000C")]
		public bool oneSided
		{
			[Token(Token = "0x60000A2")]
			[Address(RVA = "0x26093C0", Offset = "0x26079C0", VA = "0x1826093C0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A3")]
			[Address(RVA = "0x2739820", Offset = "0x2737E20", VA = "0x182739820")]
			set
			{
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002234 File Offset: 0x00000434
		// (set) Token: 0x060000A5 RID: 165 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700000D")]
		public bool selfCollisions
		{
			[Token(Token = "0x60000A4")]
			[Address(RVA = "0x26093E0", Offset = "0x26079E0", VA = "0x1826093E0")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A5")]
			[Address(RVA = "0x2739840", Offset = "0x2737E40", VA = "0x182739840")]
			set
			{
			}
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x0000224C File Offset: 0x0000044C
		// (set) Token: 0x060000A7 RID: 167 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700000E")]
		public bool distanceConstraintsEnabled
		{
			[Token(Token = "0x60000A6")]
			[Address(RVA = "0x2739860", Offset = "0x2737E60", VA = "0x182739860", Slot = "36")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000A7")]
			[Address(RVA = "0x2739870", Offset = "0x2737E70", VA = "0x182739870", Slot = "37")]
			set
			{
			}
		}

		// Token: 0x1700000F RID: 15
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x00002264 File Offset: 0x00000464
		// (set) Token: 0x060000A9 RID: 169 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x1700000F")]
		public float stretchingScale
		{
			[Token(Token = "0x60000A8")]
			[Address(RVA = "0x2739890", Offset = "0x2737E90", VA = "0x182739890", Slot = "38")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000A9")]
			[Address(RVA = "0x27398A0", Offset = "0x2737EA0", VA = "0x1827398A0", Slot = "39")]
			set
			{
			}
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x060000AA RID: 170 RVA: 0x0000227C File Offset: 0x0000047C
		// (set) Token: 0x060000AB RID: 171 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000010")]
		public float stretchCompliance
		{
			[Token(Token = "0x60000AA")]
			[Address(RVA = "0x27398C0", Offset = "0x2737EC0", VA = "0x1827398C0", Slot = "40")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000AB")]
			[Address(RVA = "0x27398D0", Offset = "0x2737ED0", VA = "0x1827398D0", Slot = "41")]
			set
			{
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00002294 File Offset: 0x00000494
		// (set) Token: 0x060000AD RID: 173 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000011")]
		public float maxCompression
		{
			[Token(Token = "0x60000AC")]
			[Address(RVA = "0x728440", Offset = "0x726A40", VA = "0x180728440", Slot = "42")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000AD")]
			[Address(RVA = "0x27398F0", Offset = "0x2737EF0", VA = "0x1827398F0", Slot = "43")]
			set
			{
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x060000AE RID: 174 RVA: 0x000022AC File Offset: 0x000004AC
		// (set) Token: 0x060000AF RID: 175 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000012")]
		public bool bendConstraintsEnabled
		{
			[Token(Token = "0x60000AE")]
			[Address(RVA = "0x2739910", Offset = "0x2737F10", VA = "0x182739910", Slot = "44")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000AF")]
			[Address(RVA = "0x2739920", Offset = "0x2737F20", VA = "0x182739920", Slot = "45")]
			set
			{
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x000022C4 File Offset: 0x000004C4
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000013")]
		public float bendCompliance
		{
			[Token(Token = "0x60000B0")]
			[Address(RVA = "0x2739940", Offset = "0x2737F40", VA = "0x182739940", Slot = "46")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000B1")]
			[Address(RVA = "0x2739950", Offset = "0x2737F50", VA = "0x182739950", Slot = "47")]
			set
			{
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x060000B2 RID: 178 RVA: 0x000022DC File Offset: 0x000004DC
		// (set) Token: 0x060000B3 RID: 179 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000014")]
		public float maxBending
		{
			[Token(Token = "0x60000B2")]
			[Address(RVA = "0x2739970", Offset = "0x2737F70", VA = "0x182739970", Slot = "48")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000B3")]
			[Address(RVA = "0x2739980", Offset = "0x2737F80", VA = "0x182739980", Slot = "49")]
			set
			{
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x000022F4 File Offset: 0x000004F4
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000015")]
		public float plasticYield
		{
			[Token(Token = "0x60000B4")]
			[Address(RVA = "0x27399A0", Offset = "0x2737FA0", VA = "0x1827399A0", Slot = "50")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000B5")]
			[Address(RVA = "0x27399B0", Offset = "0x2737FB0", VA = "0x1827399B0", Slot = "51")]
			set
			{
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000230C File Offset: 0x0000050C
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000016")]
		public float plasticCreep
		{
			[Token(Token = "0x60000B6")]
			[Address(RVA = "0x27399D0", Offset = "0x2737FD0", VA = "0x1827399D0", Slot = "52")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000B7")]
			[Address(RVA = "0x27399E0", Offset = "0x2737FE0", VA = "0x1827399E0", Slot = "53")]
			set
			{
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002324 File Offset: 0x00000524
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000017")]
		public bool aerodynamicsEnabled
		{
			[Token(Token = "0x60000B8")]
			[Address(RVA = "0x2739A00", Offset = "0x2738000", VA = "0x182739A00", Slot = "54")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60000B9")]
			[Address(RVA = "0x2739A10", Offset = "0x2738010", VA = "0x182739A10", Slot = "55")]
			set
			{
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060000BA RID: 186 RVA: 0x0000233C File Offset: 0x0000053C
		// (set) Token: 0x060000BB RID: 187 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000018")]
		public float drag
		{
			[Token(Token = "0x60000BA")]
			[Address(RVA = "0x69B270", Offset = "0x699870", VA = "0x18069B270", Slot = "56")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000BB")]
			[Address(RVA = "0x2739A30", Offset = "0x2738030", VA = "0x182739A30", Slot = "57")]
			set
			{
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060000BC RID: 188 RVA: 0x00002354 File Offset: 0x00000554
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x17000019")]
		public float lift
		{
			[Token(Token = "0x60000BC")]
			[Address(RVA = "0x2739A50", Offset = "0x2738050", VA = "0x182739A50", Slot = "58")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60000BD")]
			[Address(RVA = "0x2739A60", Offset = "0x2738060", VA = "0x182739A60", Slot = "59")]
			set
			{
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060000BE RID: 190 RVA: 0x0000236C File Offset: 0x0000056C
		[Token(Token = "0x1700001A")]
		public override bool usesCustomExternalForces
		{
			[Token(Token = "0x60000BE")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060000BF RID: 191 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x2739A80", Offset = "0x2738080", VA = "0x182739A80", Slot = "28")]
		public override void LoadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x2739B40", Offset = "0x2738140", VA = "0x182739B40", Slot = "29")]
		public override void UnloadBlueprint(ObiSolver solver)
		{
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x2739F20", Offset = "0x2738520", VA = "0x182739F20", Slot = "61")]
		public virtual void UpdateDeformableTriangles()
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x273A1B0", Offset = "0x27387B0", VA = "0x18273A1B0")]
		protected ObiClothBase()
		{
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0xA8")]
		[SerializeField]
		protected bool m_SelfCollisions;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0xA9")]
		[SerializeField]
		protected bool m_OneSided;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0xAA")]
		[SerializeField]
		protected bool _distanceConstraintsEnabled;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0xAC")]
		[SerializeField]
		protected float _stretchingScale;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0xB0")]
		[SerializeField]
		protected float _stretchCompliance;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0xB4")]
		[SerializeField]
		[Range(0f, 1f)]
		protected float _maxCompression;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0xB8")]
		[SerializeField]
		protected bool _bendConstraintsEnabled;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0xBC")]
		[SerializeField]
		protected float _bendCompliance;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0xC0")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float _maxBending;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0xC4")]
		[SerializeField]
		[Range(0f, 0.1f)]
		protected float _plasticYield;

		// Token: 0x0400007C RID: 124
		[Token(Token = "0x400007C")]
		[FieldOffset(Offset = "0xC8")]
		[SerializeField]
		protected float _plasticCreep;

		// Token: 0x0400007D RID: 125
		[Token(Token = "0x400007D")]
		[FieldOffset(Offset = "0xCC")]
		[SerializeField]
		protected bool _aerodynamicsEnabled;

		// Token: 0x0400007E RID: 126
		[Token(Token = "0x400007E")]
		[FieldOffset(Offset = "0xD0")]
		[SerializeField]
		protected float _drag;

		// Token: 0x0400007F RID: 127
		[Token(Token = "0x400007F")]
		[FieldOffset(Offset = "0xD4")]
		[SerializeField]
		protected float _lift;

		// Token: 0x04000080 RID: 128
		[Token(Token = "0x4000080")]
		[FieldOffset(Offset = "0xD8")]
		[HideInInspector]
		[NonSerialized]
		protected int trianglesOffset;
	}
}
