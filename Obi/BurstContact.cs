using System;
using Il2CppDummyDll;
using Unity.Mathematics;

namespace Obi
{
	// Token: 0x020000BA RID: 186
	[Token(Token = "0x20000BA")]
	public struct BurstContact : IConstraint, IComparable<BurstContact>
	{
		// Token: 0x060003B7 RID: 951 RVA: 0x00003734 File Offset: 0x00001934
		[Token(Token = "0x60003B7")]
		[Address(RVA = "0xE51970", Offset = "0xE4FF70", VA = "0x180E51970", Slot = "4")]
		public int GetParticleCount()
		{
			return 0;
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x0000374C File Offset: 0x0000194C
		[Token(Token = "0x60003B8")]
		[Address(RVA = "0x279A4B0", Offset = "0x2798AB0", VA = "0x18279A4B0", Slot = "5")]
		public int GetParticle(int index)
		{
			return 0;
		}

		// Token: 0x060003B9 RID: 953 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x60003B9")]
		[Address(RVA = "0x279A4C0", Offset = "0x2798AC0", VA = "0x18279A4C0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00003764 File Offset: 0x00001964
		[Token(Token = "0x60003BA")]
		[Address(RVA = "0x279A530", Offset = "0x2798B30", VA = "0x18279A530", Slot = "6")]
		public int CompareTo(BurstContact other)
		{
			return 0;
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060003BB RID: 955 RVA: 0x0000377C File Offset: 0x0000197C
		[Token(Token = "0x17000076")]
		public float TotalNormalInvMass
		{
			[Token(Token = "0x60003BB")]
			[Address(RVA = "0x279A590", Offset = "0x2798B90", VA = "0x18279A590")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00003794 File Offset: 0x00001994
		[Token(Token = "0x17000077")]
		public float TotalTangentInvMass
		{
			[Token(Token = "0x60003BC")]
			[Address(RVA = "0x279A5A0", Offset = "0x2798BA0", VA = "0x18279A5A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060003BD RID: 957 RVA: 0x000037AC File Offset: 0x000019AC
		[Token(Token = "0x17000078")]
		public float TotalBitangentInvMass
		{
			[Token(Token = "0x60003BD")]
			[Address(RVA = "0x279A5B0", Offset = "0x2798BB0", VA = "0x18279A5B0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003BE")]
		[Address(RVA = "0x279A5C0", Offset = "0x2798BC0", VA = "0x18279A5C0")]
		public void CalculateBasis(float4 relativeVelocity)
		{
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003BF")]
		[Address(RVA = "0x279A830", Offset = "0x2798E30", VA = "0x18279A830")]
		public void CalculateContactMassesA(float invMass, float4 inverseInertiaTensor, float4 position, quaternion orientation, float4 contactPoint, bool rollingContacts)
		{
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003C0")]
		[Address(RVA = "0x279AA90", Offset = "0x2799090", VA = "0x18279AA90")]
		public void CalculateContactMassesB(float invMass, float4 inverseInertiaTensor, float4 position, quaternion orientation, float4 contactPoint, bool rollingContacts)
		{
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x60003C1")]
		[Address(RVA = "0x279ACF0", Offset = "0x27992F0", VA = "0x18279ACF0")]
		public void CalculateContactMassesB(in BurstRigidbody rigidbody, in BurstAffineTransform solver2World)
		{
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x000037C4 File Offset: 0x000019C4
		[Token(Token = "0x60003C2")]
		[Address(RVA = "0x279AF20", Offset = "0x2799520", VA = "0x18279AF20")]
		public float SolveAdhesion(float4 posA, float4 posB, float stickDistance, float stickiness, float dt)
		{
			return 0f;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x000037DC File Offset: 0x000019DC
		[Token(Token = "0x60003C3")]
		[Address(RVA = "0x279B0B0", Offset = "0x27996B0", VA = "0x18279B0B0")]
		public float SolvePenetration(float4 posA, float4 posB, float maxDepenetrationDelta)
		{
			return 0f;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x000037F4 File Offset: 0x000019F4
		[Token(Token = "0x60003C4")]
		[Address(RVA = "0x279B1F0", Offset = "0x27997F0", VA = "0x18279B1F0")]
		public float2 SolveFriction(float4 relativeVelocity, float staticFriction, float dynamicFriction, float dt)
		{
			return default(float2);
		}

		// Token: 0x060003C5 RID: 965 RVA: 0x0000380C File Offset: 0x00001A0C
		[Token(Token = "0x60003C5")]
		[Address(RVA = "0x279B470", Offset = "0x2799A70", VA = "0x18279B470")]
		public float SolveRollingFriction(float4 angularVelocityA, float4 angularVelocityB, float rollingFriction, float invMassA, float invMassB, ref float4 rolling_axis)
		{
			return 0f;
		}

		// Token: 0x0400041E RID: 1054
		[Token(Token = "0x400041E")]
		[FieldOffset(Offset = "0x0")]
		public float4 pointA;

		// Token: 0x0400041F RID: 1055
		[Token(Token = "0x400041F")]
		[FieldOffset(Offset = "0x10")]
		public float4 pointB;

		// Token: 0x04000420 RID: 1056
		[Token(Token = "0x4000420")]
		[FieldOffset(Offset = "0x20")]
		public float4 normal;

		// Token: 0x04000421 RID: 1057
		[Token(Token = "0x4000421")]
		[FieldOffset(Offset = "0x30")]
		public float4 tangent;

		// Token: 0x04000422 RID: 1058
		[Token(Token = "0x4000422")]
		[FieldOffset(Offset = "0x40")]
		public float4 bitangent;

		// Token: 0x04000423 RID: 1059
		[Token(Token = "0x4000423")]
		[FieldOffset(Offset = "0x50")]
		public float distance;

		// Token: 0x04000424 RID: 1060
		[Token(Token = "0x4000424")]
		[FieldOffset(Offset = "0x54")]
		private float normalLambda;

		// Token: 0x04000425 RID: 1061
		[Token(Token = "0x4000425")]
		[FieldOffset(Offset = "0x58")]
		private float tangentLambda;

		// Token: 0x04000426 RID: 1062
		[Token(Token = "0x4000426")]
		[FieldOffset(Offset = "0x5C")]
		private float bitangentLambda;

		// Token: 0x04000427 RID: 1063
		[Token(Token = "0x4000427")]
		[FieldOffset(Offset = "0x60")]
		private float stickLambda;

		// Token: 0x04000428 RID: 1064
		[Token(Token = "0x4000428")]
		[FieldOffset(Offset = "0x64")]
		private float rollingFrictionImpulse;

		// Token: 0x04000429 RID: 1065
		[Token(Token = "0x4000429")]
		[FieldOffset(Offset = "0x68")]
		public int bodyA;

		// Token: 0x0400042A RID: 1066
		[Token(Token = "0x400042A")]
		[FieldOffset(Offset = "0x6C")]
		public int bodyB;

		// Token: 0x0400042B RID: 1067
		[Token(Token = "0x400042B")]
		[FieldOffset(Offset = "0x70")]
		public float normalInvMassA;

		// Token: 0x0400042C RID: 1068
		[Token(Token = "0x400042C")]
		[FieldOffset(Offset = "0x74")]
		public float tangentInvMassA;

		// Token: 0x0400042D RID: 1069
		[Token(Token = "0x400042D")]
		[FieldOffset(Offset = "0x78")]
		public float bitangentInvMassA;

		// Token: 0x0400042E RID: 1070
		[Token(Token = "0x400042E")]
		[FieldOffset(Offset = "0x7C")]
		public float normalInvMassB;

		// Token: 0x0400042F RID: 1071
		[Token(Token = "0x400042F")]
		[FieldOffset(Offset = "0x80")]
		public float tangentInvMassB;

		// Token: 0x04000430 RID: 1072
		[Token(Token = "0x4000430")]
		[FieldOffset(Offset = "0x84")]
		public float bitangentInvMassB;

		// Token: 0x04000431 RID: 1073
		[Token(Token = "0x4000431")]
		[FieldOffset(Offset = "0x88")]
		public double pad0;
	}
}
