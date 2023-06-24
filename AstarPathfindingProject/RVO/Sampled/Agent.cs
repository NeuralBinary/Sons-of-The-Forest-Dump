using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Pathfinding.RVO.Sampled
{
	// Token: 0x02000161 RID: 353
	[Token(Token = "0x2000161")]
	public class Agent : IAgent
	{
		// Token: 0x17000184 RID: 388
		// (get) Token: 0x06000B05 RID: 2821 RVA: 0x00006A7C File Offset: 0x00004C7C
		// (set) Token: 0x06000B06 RID: 2822 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000184")]
		public Vector2 Position
		{
			[Token(Token = "0x6000B05")]
			[Address(RVA = "0x728260", Offset = "0x726860", VA = "0x180728260", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B06")]
			[Address(RVA = "0x728280", Offset = "0x726880", VA = "0x180728280", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000B07 RID: 2823 RVA: 0x00006A94 File Offset: 0x00004C94
		// (set) Token: 0x06000B08 RID: 2824 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000185")]
		public float ElevationCoordinate
		{
			[Token(Token = "0x6000B07")]
			[Address(RVA = "0x6124C0", Offset = "0x610AC0", VA = "0x1806124C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B08")]
			[Address(RVA = "0x6124D0", Offset = "0x610AD0", VA = "0x1806124D0", Slot = "7")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000B09 RID: 2825 RVA: 0x00006AAC File Offset: 0x00004CAC
		// (set) Token: 0x06000B0A RID: 2826 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000186")]
		public Vector2 CalculatedTargetPoint
		{
			[Token(Token = "0x6000B09")]
			[Address(RVA = "0x728290", Offset = "0x726890", VA = "0x180728290", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Token(Token = "0x6000B0A")]
			[Address(RVA = "0x7282B0", Offset = "0x7268B0", VA = "0x1807282B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000B0B RID: 2827 RVA: 0x00006AC4 File Offset: 0x00004CC4
		// (set) Token: 0x06000B0C RID: 2828 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000187")]
		public float CalculatedSpeed
		{
			[Token(Token = "0x6000B0B")]
			[Address(RVA = "0x7282C0", Offset = "0x7268C0", VA = "0x1807282C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B0C")]
			[Address(RVA = "0x7282D0", Offset = "0x7268D0", VA = "0x1807282D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000B0D RID: 2829 RVA: 0x00006ADC File Offset: 0x00004CDC
		// (set) Token: 0x06000B0E RID: 2830 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000188")]
		public bool Locked
		{
			[Token(Token = "0x6000B0D")]
			[Address(RVA = "0x7282E0", Offset = "0x7268E0", VA = "0x1807282E0", Slot = "11")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B0E")]
			[Address(RVA = "0x7282F0", Offset = "0x7268F0", VA = "0x1807282F0", Slot = "12")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x00006AF4 File Offset: 0x00004CF4
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000189")]
		public float Radius
		{
			[Token(Token = "0x6000B0F")]
			[Address(RVA = "0x728300", Offset = "0x726900", VA = "0x180728300", Slot = "13")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x728310", Offset = "0x726910", VA = "0x180728310", Slot = "14")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000B11 RID: 2833 RVA: 0x00006B0C File Offset: 0x00004D0C
		// (set) Token: 0x06000B12 RID: 2834 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700018A")]
		public float Height
		{
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0x728320", Offset = "0x726920", VA = "0x180728320", Slot = "15")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B12")]
			[Address(RVA = "0x728330", Offset = "0x726930", VA = "0x180728330", Slot = "16")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000B13 RID: 2835 RVA: 0x00006B24 File Offset: 0x00004D24
		// (set) Token: 0x06000B14 RID: 2836 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700018B")]
		public float AgentTimeHorizon
		{
			[Token(Token = "0x6000B13")]
			[Address(RVA = "0x728340", Offset = "0x726940", VA = "0x180728340", Slot = "17")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B14")]
			[Address(RVA = "0x728350", Offset = "0x726950", VA = "0x180728350", Slot = "18")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000B15 RID: 2837 RVA: 0x00006B3C File Offset: 0x00004D3C
		// (set) Token: 0x06000B16 RID: 2838 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700018C")]
		public float ObstacleTimeHorizon
		{
			[Token(Token = "0x6000B15")]
			[Address(RVA = "0x727F30", Offset = "0x726530", VA = "0x180727F30", Slot = "19")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B16")]
			[Address(RVA = "0x728360", Offset = "0x726960", VA = "0x180728360", Slot = "20")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x06000B17 RID: 2839 RVA: 0x00006B54 File Offset: 0x00004D54
		// (set) Token: 0x06000B18 RID: 2840 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700018D")]
		public int MaxNeighbours
		{
			[Token(Token = "0x6000B17")]
			[Address(RVA = "0x728370", Offset = "0x726970", VA = "0x180728370", Slot = "21")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B18")]
			[Address(RVA = "0x728380", Offset = "0x726980", VA = "0x180728380", Slot = "22")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000B19 RID: 2841 RVA: 0x00006B6C File Offset: 0x00004D6C
		// (set) Token: 0x06000B1A RID: 2842 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700018E")]
		public int NeighbourCount
		{
			[Token(Token = "0x6000B19")]
			[Address(RVA = "0x728390", Offset = "0x726990", VA = "0x180728390", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6000B1A")]
			[Address(RVA = "0x7283A0", Offset = "0x7269A0", VA = "0x1807283A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000B1B RID: 2843 RVA: 0x00006B84 File Offset: 0x00004D84
		// (set) Token: 0x06000B1C RID: 2844 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x1700018F")]
		public RVOLayer Layer
		{
			[Token(Token = "0x6000B1B")]
			[Address(RVA = "0x7283B0", Offset = "0x7269B0", VA = "0x1807283B0", Slot = "24")]
			[CompilerGenerated]
			get
			{
				return (RVOLayer)0;
			}
			[Token(Token = "0x6000B1C")]
			[Address(RVA = "0x7283C0", Offset = "0x7269C0", VA = "0x1807283C0", Slot = "25")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000B1D RID: 2845 RVA: 0x00006B9C File Offset: 0x00004D9C
		// (set) Token: 0x06000B1E RID: 2846 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000190")]
		public RVOLayer CollidesWith
		{
			[Token(Token = "0x6000B1D")]
			[Address(RVA = "0x7283D0", Offset = "0x7269D0", VA = "0x1807283D0", Slot = "26")]
			[CompilerGenerated]
			get
			{
				return (RVOLayer)0;
			}
			[Token(Token = "0x6000B1E")]
			[Address(RVA = "0x7283E0", Offset = "0x7269E0", VA = "0x1807283E0", Slot = "27")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x06000B1F RID: 2847 RVA: 0x00006BB4 File Offset: 0x00004DB4
		// (set) Token: 0x06000B20 RID: 2848 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000191")]
		public bool DebugDraw
		{
			[Token(Token = "0x6000B1F")]
			[Address(RVA = "0x7283F0", Offset = "0x7269F0", VA = "0x1807283F0", Slot = "28")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000B20")]
			[Address(RVA = "0x728400", Offset = "0x726A00", VA = "0x180728400", Slot = "29")]
			set
			{
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x06000B21 RID: 2849 RVA: 0x00006BCC File Offset: 0x00004DCC
		// (set) Token: 0x06000B22 RID: 2850 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000192")]
		public float Priority
		{
			[Token(Token = "0x6000B21")]
			[Address(RVA = "0x728440", Offset = "0x726A40", VA = "0x180728440", Slot = "31")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6000B22")]
			[Address(RVA = "0x728450", Offset = "0x726A50", VA = "0x180728450", Slot = "32")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x06000B23 RID: 2851 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000B24 RID: 2852 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x17000193")]
		public Action PreCalculationCallback
		{
			[Token(Token = "0x6000B23")]
			[Address(RVA = "0x671190", Offset = "0x66F790", VA = "0x180671190")]
			[CompilerGenerated]
			private get
			{
				return null;
			}
			[Token(Token = "0x6000B24")]
			[Address(RVA = "0x728460", Offset = "0x726A60", VA = "0x180728460", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B25")]
		[Address(RVA = "0x7284C0", Offset = "0x726AC0", VA = "0x1807284C0", Slot = "10")]
		public void SetTarget(Vector2 targetPoint, float desiredSpeed, float maxSpeed)
		{
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B26")]
		[Address(RVA = "0x7285A0", Offset = "0x726BA0", VA = "0x1807285A0", Slot = "34")]
		public void SetCollisionNormal(Vector2 normal)
		{
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B27")]
		[Address(RVA = "0x7285B0", Offset = "0x726BB0", VA = "0x1807285B0", Slot = "35")]
		public void ForceSetVelocity(Vector2 velocity)
		{
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000B28 RID: 2856 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000194")]
		public List<ObstacleVertex> NeighbourObstacles
		{
			[Token(Token = "0x6000B28")]
			[Address(RVA = "0x5EF5A0", Offset = "0x5EDBA0", VA = "0x1805EF5A0", Slot = "30")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B29")]
		[Address(RVA = "0x728630", Offset = "0x726C30", VA = "0x180728630")]
		public Agent(Vector2 pos, float elevationCoordinate)
		{
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B2A")]
		[Address(RVA = "0x728960", Offset = "0x726F60", VA = "0x180728960")]
		public void BufferSwitch()
		{
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B2B")]
		[Address(RVA = "0x728BE0", Offset = "0x7271E0", VA = "0x180728BE0")]
		public void PreCalculation()
		{
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B2C")]
		[Address(RVA = "0x728C00", Offset = "0x727200", VA = "0x180728C00")]
		public void PostCalculation()
		{
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B2D")]
		[Address(RVA = "0x728D00", Offset = "0x727300", VA = "0x180728D00")]
		public void CalculateNeighbours()
		{
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x00006BE4 File Offset: 0x00004DE4
		[Token(Token = "0x6000B2E")]
		[Address(RVA = "0x728F10", Offset = "0x727510", VA = "0x180728F10")]
		private static float Sqr(float x)
		{
			return 0f;
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x00006BFC File Offset: 0x00004DFC
		[Token(Token = "0x6000B2F")]
		[Address(RVA = "0x728F20", Offset = "0x727520", VA = "0x180728F20")]
		internal float InsertAgentNeighbour(Agent agent, float rangeSq)
		{
			return 0f;
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x00006C14 File Offset: 0x00004E14
		[Token(Token = "0x6000B30")]
		[Address(RVA = "0x6E2EB0", Offset = "0x6E14B0", VA = "0x1806E2EB0")]
		private static Vector3 FromXZ(Vector2 p)
		{
			return default(Vector3);
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x00006C2C File Offset: 0x00004E2C
		[Token(Token = "0x6000B31")]
		[Address(RVA = "0x6E2E90", Offset = "0x6E1490", VA = "0x1806E2E90")]
		private static Vector2 ToXZ(Vector3 p)
		{
			return default(Vector2);
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00006C44 File Offset: 0x00004E44
		[Token(Token = "0x6000B32")]
		[Address(RVA = "0x7292B0", Offset = "0x7278B0", VA = "0x1807292B0")]
		private Vector2 To2D(Vector3 p, out float elevation)
		{
			return default(Vector2);
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B33")]
		[Address(RVA = "0x729310", Offset = "0x727910", VA = "0x180729310")]
		private static void DrawVO(Vector2 circleCenter, float radius, Vector2 origin)
		{
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B34")]
		[Address(RVA = "0x729890", Offset = "0x727E90", VA = "0x180729890")]
		internal void CalculateVelocity(Simulator.WorkerContext context)
		{
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00006C5C File Offset: 0x00004E5C
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x729CB0", Offset = "0x7282B0", VA = "0x180729CB0")]
		private static Color Rainbow(float v)
		{
			return default(Color);
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x729D00", Offset = "0x728300", VA = "0x180729D00")]
		private void GenerateObstacleVOs(Agent.VOBuffer vos)
		{
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x00002082 File Offset: 0x00000282
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x72A250", Offset = "0x728850", VA = "0x18072A250")]
		private void GenerateNeighbourAgentVOs(Agent.VOBuffer vos)
		{
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x00006C74 File Offset: 0x00004E74
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x72A6F0", Offset = "0x728CF0", VA = "0x18072A6F0")]
		private Vector2 GradientDescent(Agent.VOBuffer vos, Vector2 sampleAround1, Vector2 sampleAround2)
		{
			return default(Vector2);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00006C8C File Offset: 0x00004E8C
		[Token(Token = "0x6000B39")]
		[Address(RVA = "0x72A900", Offset = "0x728F00", VA = "0x18072A900")]
		private static bool BiasDesiredVelocity(Agent.VOBuffer vos, ref Vector2 desiredVelocity, ref Vector2 targetPointInVelocitySpace, float maxBiasRadians)
		{
			return default(bool);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x00006CA4 File Offset: 0x00004EA4
		[Token(Token = "0x6000B3A")]
		[Address(RVA = "0x72AA70", Offset = "0x729070", VA = "0x18072AA70")]
		private Vector2 EvaluateGradient(Agent.VOBuffer vos, Vector2 p, out float value)
		{
			return default(Vector2);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00006CBC File Offset: 0x00004EBC
		[Token(Token = "0x6000B3B")]
		[Address(RVA = "0x72ADF0", Offset = "0x7293F0", VA = "0x18072ADF0")]
		private Vector2 Trace(Agent.VOBuffer vos, Vector2 p, out float score)
		{
			return default(Vector2);
		}

		// Token: 0x040007A5 RID: 1957
		[Token(Token = "0x40007A5")]
		[FieldOffset(Offset = "0x10")]
		internal float radius;

		// Token: 0x040007A6 RID: 1958
		[Token(Token = "0x40007A6")]
		[FieldOffset(Offset = "0x14")]
		internal float height;

		// Token: 0x040007A7 RID: 1959
		[Token(Token = "0x40007A7")]
		[FieldOffset(Offset = "0x18")]
		internal float desiredSpeed;

		// Token: 0x040007A8 RID: 1960
		[Token(Token = "0x40007A8")]
		[FieldOffset(Offset = "0x1C")]
		internal float maxSpeed;

		// Token: 0x040007A9 RID: 1961
		[Token(Token = "0x40007A9")]
		[FieldOffset(Offset = "0x20")]
		internal float agentTimeHorizon;

		// Token: 0x040007AA RID: 1962
		[Token(Token = "0x40007AA")]
		[FieldOffset(Offset = "0x24")]
		internal float obstacleTimeHorizon;

		// Token: 0x040007AB RID: 1963
		[Token(Token = "0x40007AB")]
		[FieldOffset(Offset = "0x28")]
		internal bool locked;

		// Token: 0x040007AC RID: 1964
		[Token(Token = "0x40007AC")]
		[FieldOffset(Offset = "0x2C")]
		private RVOLayer layer;

		// Token: 0x040007AD RID: 1965
		[Token(Token = "0x40007AD")]
		[FieldOffset(Offset = "0x30")]
		private RVOLayer collidesWith;

		// Token: 0x040007AE RID: 1966
		[Token(Token = "0x40007AE")]
		[FieldOffset(Offset = "0x34")]
		private int maxNeighbours;

		// Token: 0x040007AF RID: 1967
		[Token(Token = "0x40007AF")]
		[FieldOffset(Offset = "0x38")]
		internal Vector2 position;

		// Token: 0x040007B0 RID: 1968
		[Token(Token = "0x40007B0")]
		[FieldOffset(Offset = "0x40")]
		private float elevationCoordinate;

		// Token: 0x040007B1 RID: 1969
		[Token(Token = "0x40007B1")]
		[FieldOffset(Offset = "0x44")]
		private Vector2 currentVelocity;

		// Token: 0x040007B2 RID: 1970
		[Token(Token = "0x40007B2")]
		[FieldOffset(Offset = "0x4C")]
		private Vector2 desiredTargetPointInVelocitySpace;

		// Token: 0x040007B3 RID: 1971
		[Token(Token = "0x40007B3")]
		[FieldOffset(Offset = "0x54")]
		private Vector2 desiredVelocity;

		// Token: 0x040007B4 RID: 1972
		[Token(Token = "0x40007B4")]
		[FieldOffset(Offset = "0x5C")]
		private Vector2 nextTargetPoint;

		// Token: 0x040007B5 RID: 1973
		[Token(Token = "0x40007B5")]
		[FieldOffset(Offset = "0x64")]
		private float nextDesiredSpeed;

		// Token: 0x040007B6 RID: 1974
		[Token(Token = "0x40007B6")]
		[FieldOffset(Offset = "0x68")]
		private float nextMaxSpeed;

		// Token: 0x040007B7 RID: 1975
		[Token(Token = "0x40007B7")]
		[FieldOffset(Offset = "0x6C")]
		private Vector2 collisionNormal;

		// Token: 0x040007B8 RID: 1976
		[Token(Token = "0x40007B8")]
		[FieldOffset(Offset = "0x74")]
		private bool manuallyControlled;

		// Token: 0x040007B9 RID: 1977
		[Token(Token = "0x40007B9")]
		[FieldOffset(Offset = "0x75")]
		private bool debugDraw;

		// Token: 0x040007C9 RID: 1993
		[Token(Token = "0x40007C9")]
		[FieldOffset(Offset = "0xC0")]
		internal Agent next;

		// Token: 0x040007CA RID: 1994
		[Token(Token = "0x40007CA")]
		[FieldOffset(Offset = "0xC8")]
		private float calculatedSpeed;

		// Token: 0x040007CB RID: 1995
		[Token(Token = "0x40007CB")]
		[FieldOffset(Offset = "0xCC")]
		private Vector2 calculatedTargetPoint;

		// Token: 0x040007CC RID: 1996
		[Token(Token = "0x40007CC")]
		[FieldOffset(Offset = "0xD8")]
		internal Simulator simulator;

		// Token: 0x040007CD RID: 1997
		[Token(Token = "0x40007CD")]
		[FieldOffset(Offset = "0xE0")]
		private List<Agent> neighbours;

		// Token: 0x040007CE RID: 1998
		[Token(Token = "0x40007CE")]
		[FieldOffset(Offset = "0xE8")]
		private List<float> neighbourDists;

		// Token: 0x040007CF RID: 1999
		[Token(Token = "0x40007CF")]
		[FieldOffset(Offset = "0xF0")]
		private List<ObstacleVertex> obstaclesBuffered;

		// Token: 0x040007D0 RID: 2000
		[Token(Token = "0x40007D0")]
		[FieldOffset(Offset = "0xF8")]
		private List<ObstacleVertex> obstacles;

		// Token: 0x040007D1 RID: 2001
		[Token(Token = "0x40007D1")]
		private const float DesiredVelocityWeight = 0.1f;

		// Token: 0x040007D2 RID: 2002
		[Token(Token = "0x40007D2")]
		private const float WallWeight = 5f;

		// Token: 0x02000162 RID: 354
		[Token(Token = "0x2000162")]
		internal struct VO
		{
			// Token: 0x06000B3C RID: 2876 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000B3C")]
			[Address(RVA = "0x72B0D0", Offset = "0x7296D0", VA = "0x18072B0D0")]
			public VO(Vector2 center, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime)
			{
			}

			// Token: 0x06000B3D RID: 2877 RVA: 0x00006CD4 File Offset: 0x00004ED4
			[Token(Token = "0x6000B3D")]
			[Address(RVA = "0x72B690", Offset = "0x729C90", VA = "0x18072B690")]
			public static Agent.VO SegmentObstacle(Vector2 segmentStart, Vector2 segmentEnd, Vector2 offset, float radius, float inverseDt, float inverseDeltaTime)
			{
				return default(Agent.VO);
			}

			// Token: 0x06000B3E RID: 2878 RVA: 0x00006CEC File Offset: 0x00004EEC
			[Token(Token = "0x6000B3E")]
			[Address(RVA = "0x72BE10", Offset = "0x72A410", VA = "0x18072BE10")]
			public static float SignedDistanceFromLine(Vector2 a, Vector2 dir, Vector2 p)
			{
				return 0f;
			}

			// Token: 0x06000B3F RID: 2879 RVA: 0x00006D04 File Offset: 0x00004F04
			[Token(Token = "0x6000B3F")]
			[Address(RVA = "0x72BE50", Offset = "0x72A450", VA = "0x18072BE50")]
			public Vector2 ScaledGradient(Vector2 p, out float weight)
			{
				return default(Vector2);
			}

			// Token: 0x06000B40 RID: 2880 RVA: 0x00006D1C File Offset: 0x00004F1C
			[Token(Token = "0x6000B40")]
			[Address(RVA = "0x72BED0", Offset = "0x72A4D0", VA = "0x18072BED0")]
			public Vector2 Gradient(Vector2 p, out float weight)
			{
				return default(Vector2);
			}

			// Token: 0x040007D3 RID: 2003
			[Token(Token = "0x40007D3")]
			[FieldOffset(Offset = "0x0")]
			private Vector2 line1;

			// Token: 0x040007D4 RID: 2004
			[Token(Token = "0x40007D4")]
			[FieldOffset(Offset = "0x8")]
			private Vector2 line2;

			// Token: 0x040007D5 RID: 2005
			[Token(Token = "0x40007D5")]
			[FieldOffset(Offset = "0x10")]
			private Vector2 dir1;

			// Token: 0x040007D6 RID: 2006
			[Token(Token = "0x40007D6")]
			[FieldOffset(Offset = "0x18")]
			private Vector2 dir2;

			// Token: 0x040007D7 RID: 2007
			[Token(Token = "0x40007D7")]
			[FieldOffset(Offset = "0x20")]
			private Vector2 cutoffLine;

			// Token: 0x040007D8 RID: 2008
			[Token(Token = "0x40007D8")]
			[FieldOffset(Offset = "0x28")]
			private Vector2 cutoffDir;

			// Token: 0x040007D9 RID: 2009
			[Token(Token = "0x40007D9")]
			[FieldOffset(Offset = "0x30")]
			private Vector2 circleCenter;

			// Token: 0x040007DA RID: 2010
			[Token(Token = "0x40007DA")]
			[FieldOffset(Offset = "0x38")]
			private bool colliding;

			// Token: 0x040007DB RID: 2011
			[Token(Token = "0x40007DB")]
			[FieldOffset(Offset = "0x3C")]
			private float radius;

			// Token: 0x040007DC RID: 2012
			[Token(Token = "0x40007DC")]
			[FieldOffset(Offset = "0x40")]
			private float weightFactor;

			// Token: 0x040007DD RID: 2013
			[Token(Token = "0x40007DD")]
			[FieldOffset(Offset = "0x44")]
			private float weightBonus;

			// Token: 0x040007DE RID: 2014
			[Token(Token = "0x40007DE")]
			[FieldOffset(Offset = "0x48")]
			private Vector2 segmentStart;

			// Token: 0x040007DF RID: 2015
			[Token(Token = "0x40007DF")]
			[FieldOffset(Offset = "0x50")]
			private Vector2 segmentEnd;

			// Token: 0x040007E0 RID: 2016
			[Token(Token = "0x40007E0")]
			[FieldOffset(Offset = "0x58")]
			private bool segment;
		}

		// Token: 0x02000163 RID: 355
		[Token(Token = "0x2000163")]
		internal class VOBuffer
		{
			// Token: 0x06000B41 RID: 2881 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000B41")]
			[Address(RVA = "0x72C280", Offset = "0x72A880", VA = "0x18072C280")]
			public void Clear()
			{
			}

			// Token: 0x06000B42 RID: 2882 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000B42")]
			[Address(RVA = "0x72C290", Offset = "0x72A890", VA = "0x18072C290")]
			public VOBuffer(int n)
			{
			}

			// Token: 0x06000B43 RID: 2883 RVA: 0x00002082 File Offset: 0x00000282
			[Token(Token = "0x6000B43")]
			[Address(RVA = "0x72C330", Offset = "0x72A930", VA = "0x18072C330")]
			public void Add(Agent.VO vo)
			{
			}

			// Token: 0x040007E1 RID: 2017
			[Token(Token = "0x40007E1")]
			[FieldOffset(Offset = "0x10")]
			public Agent.VO[] buffer;

			// Token: 0x040007E2 RID: 2018
			[Token(Token = "0x40007E2")]
			[FieldOffset(Offset = "0x18")]
			public int length;
		}
	}
}
