using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace Obi
{
	// Token: 0x020001F7 RID: 503
	[Token(Token = "0x20001F7")]
	[Serializable]
	public class ObiPath
	{
		// Token: 0x06000A27 RID: 2599 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A27")]
		[Address(RVA = "0x2814020", Offset = "0x2812620", VA = "0x182814020")]
		private IEnumerable<IObiPathDataChannel> GetDataChannels()
		{
			return null;
		}

		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000A28 RID: 2600 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x17000199")]
		public ObiPointsDataChannel points
		{
			[Token(Token = "0x6000A28")]
			[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700019A")]
		public ObiNormalDataChannel normals
		{
			[Token(Token = "0x6000A29")]
			[Address(RVA = "0x5B2E00", Offset = "0x5B1400", VA = "0x1805B2E00")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000A2A RID: 2602 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700019B")]
		public ObiColorDataChannel colors
		{
			[Token(Token = "0x6000A2A")]
			[Address(RVA = "0x5B2E70", Offset = "0x5B1470", VA = "0x1805B2E70")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000A2B RID: 2603 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700019C")]
		public ObiThicknessDataChannel thicknesses
		{
			[Token(Token = "0x6000A2B")]
			[Address(RVA = "0x5B2E80", Offset = "0x5B1480", VA = "0x1805B2E80")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700019D")]
		public ObiMassDataChannel masses
		{
			[Token(Token = "0x6000A2C")]
			[Address(RVA = "0x5B2EF0", Offset = "0x5B14F0", VA = "0x1805B2EF0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x06000A2D RID: 2605 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700019E")]
		public ObiRotationalMassDataChannel rotationalMasses
		{
			[Token(Token = "0x6000A2D")]
			[Address(RVA = "0x5AC7C0", Offset = "0x5AADC0", VA = "0x1805AC7C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x06000A2E RID: 2606 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x1700019F")]
		public ObiPhaseDataChannel phases
		{
			[Token(Token = "0x6000A2E")]
			[Address(RVA = "0x6710C0", Offset = "0x66F6C0", VA = "0x1806710C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x170001A0")]
		public ReadOnlyCollection<float> ArcLengthTable
		{
			[Token(Token = "0x6000A2F")]
			[Address(RVA = "0x28140C0", Offset = "0x28126C0", VA = "0x1828140C0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000A30 RID: 2608 RVA: 0x0000545C File Offset: 0x0000365C
		[Token(Token = "0x170001A1")]
		public float Length
		{
			[Token(Token = "0x6000A30")]
			[Address(RVA = "0x1F3D0A0", Offset = "0x1F3B6A0", VA = "0x181F3D0A0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000A31 RID: 2609 RVA: 0x00005474 File Offset: 0x00003674
		[Token(Token = "0x170001A2")]
		public int ArcLengthSamples
		{
			[Token(Token = "0x6000A31")]
			[Address(RVA = "0xE59A00", Offset = "0xE58000", VA = "0x180E59A00")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000A32 RID: 2610 RVA: 0x0000548C File Offset: 0x0000368C
		[Token(Token = "0x170001A3")]
		public int ControlPointCount
		{
			[Token(Token = "0x6000A32")]
			[Address(RVA = "0x2814180", Offset = "0x2812780", VA = "0x182814180")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000A33 RID: 2611 RVA: 0x000054A4 File Offset: 0x000036A4
		// (set) Token: 0x06000A34 RID: 2612 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x170001A4")]
		public bool Closed
		{
			[Token(Token = "0x6000A33")]
			[Address(RVA = "0x5F2120", Offset = "0x5F0720", VA = "0x1805F2120")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000A34")]
			[Address(RVA = "0x28141D0", Offset = "0x28127D0", VA = "0x1828141D0")]
			set
			{
			}
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x000054BC File Offset: 0x000036BC
		[Token(Token = "0x6000A35")]
		[Address(RVA = "0x28141E0", Offset = "0x28127E0", VA = "0x1828141E0")]
		public int GetSpanCount()
		{
			return 0;
		}

		// Token: 0x06000A36 RID: 2614 RVA: 0x000054D4 File Offset: 0x000036D4
		[Token(Token = "0x6000A36")]
		[Address(RVA = "0x2814240", Offset = "0x2812840", VA = "0x182814240")]
		public int GetSpanControlPointForMu(float mu, out float spanMu)
		{
			return 0;
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x000054EC File Offset: 0x000036EC
		[Token(Token = "0x6000A37")]
		[Address(RVA = "0x28142E0", Offset = "0x28128E0", VA = "0x1828142E0")]
		public int GetClosestControlPointIndex(float mu)
		{
			return 0;
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00005504 File Offset: 0x00003704
		[Token(Token = "0x6000A38")]
		[Address(RVA = "0x28143F0", Offset = "0x28129F0", VA = "0x1828143F0")]
		public float GetMuAtLenght(float length)
		{
			return 0f;
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0000551C File Offset: 0x0000371C
		[Token(Token = "0x6000A39")]
		[Address(RVA = "0x2814560", Offset = "0x2812B60", VA = "0x182814560")]
		public float RecalculateLenght(Matrix4x4 referenceFrame, float acc, int maxevals)
		{
			return 0f;
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00005534 File Offset: 0x00003734
		[Token(Token = "0x6000A3A")]
		[Address(RVA = "0x2814DD0", Offset = "0x28133D0", VA = "0x182814DD0")]
		private float GaussLobattoIntegrationStep(Vector3 p1, Vector3 p2, Vector3 p3, Vector3 p4, float a, float b, float fa, float fb, int nevals, int maxevals, float acc)
		{
			return 0f;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A3B")]
		[Address(RVA = "0x28157A0", Offset = "0x2813DA0", VA = "0x1828157A0")]
		public void SetName(int index, string name)
		{
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00002186 File Offset: 0x00000386
		[Token(Token = "0x6000A3C")]
		[Address(RVA = "0x2815850", Offset = "0x2813E50", VA = "0x182815850")]
		public string GetName(int index)
		{
			return null;
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A3D")]
		[Address(RVA = "0x28158C0", Offset = "0x2813EC0", VA = "0x1828158C0")]
		public void AddControlPoint(Vector3 position, Vector3 inTangentVector, Vector3 outTangentVector, Vector3 normal, float mass, float rotationalMass, float thickness, int phase, Color color, string name)
		{
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A3E")]
		[Address(RVA = "0x2815A40", Offset = "0x2814040", VA = "0x182815A40")]
		public void InsertControlPoint(int index, Vector3 position, Vector3 inTangentVector, Vector3 outTangentVector, Vector3 normal, float mass, float rotationalMass, float thickness, int phase, Color color, string name)
		{
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0000554C File Offset: 0x0000374C
		[Token(Token = "0x6000A3F")]
		[Address(RVA = "0x2815D00", Offset = "0x2814300", VA = "0x182815D00")]
		public int InsertControlPoint(float mu)
		{
			return 0;
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A40")]
		[Address(RVA = "0x2816AA0", Offset = "0x28150A0", VA = "0x182816AA0")]
		public void Clear()
		{
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A41")]
		[Address(RVA = "0x2816B20", Offset = "0x2815120", VA = "0x182816B20")]
		public void RemoveControlPoint(int index)
		{
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A42")]
		[Address(RVA = "0x2816E20", Offset = "0x2815420", VA = "0x182816E20")]
		public void FlushEvents()
		{
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A43")]
		[Address(RVA = "0x2817140", Offset = "0x2815740", VA = "0x182817140")]
		public ObiPath()
		{
		}

		// Token: 0x04000815 RID: 2069
		[Token(Token = "0x4000815")]
		[FieldOffset(Offset = "0x10")]
		[HideInInspector]
		[SerializeField]
		private List<string> m_Names;

		// Token: 0x04000816 RID: 2070
		[Token(Token = "0x4000816")]
		[FieldOffset(Offset = "0x18")]
		[HideInInspector]
		[SerializeField]
		public ObiPointsDataChannel m_Points;

		// Token: 0x04000817 RID: 2071
		[Token(Token = "0x4000817")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[HideInInspector]
		private ObiNormalDataChannel m_Normals;

		// Token: 0x04000818 RID: 2072
		[Token(Token = "0x4000818")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		private ObiColorDataChannel m_Colors;

		// Token: 0x04000819 RID: 2073
		[Token(Token = "0x4000819")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[HideInInspector]
		private ObiThicknessDataChannel m_Thickness;

		// Token: 0x0400081A RID: 2074
		[Token(Token = "0x400081A")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		[HideInInspector]
		private ObiMassDataChannel m_Masses;

		// Token: 0x0400081B RID: 2075
		[Token(Token = "0x400081B")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[HideInInspector]
		private ObiRotationalMassDataChannel m_RotationalMasses;

		// Token: 0x0400081C RID: 2076
		[Token(Token = "0x400081C")]
		[FieldOffset(Offset = "0x48")]
		[HideInInspector]
		[SerializeField]
		private ObiPhaseDataChannel m_Phases;

		// Token: 0x0400081D RID: 2077
		[Token(Token = "0x400081D")]
		[FieldOffset(Offset = "0x50")]
		[HideInInspector]
		[SerializeField]
		private bool m_Closed;

		// Token: 0x0400081E RID: 2078
		[Token(Token = "0x400081E")]
		[FieldOffset(Offset = "0x51")]
		protected bool dirty;

		// Token: 0x0400081F RID: 2079
		[Token(Token = "0x400081F")]
		protected const int arcLenghtSamples = 20;

		// Token: 0x04000820 RID: 2080
		[Token(Token = "0x4000820")]
		[FieldOffset(Offset = "0x58")]
		[HideInInspector]
		[SerializeField]
		protected List<float> m_ArcLengthTable;

		// Token: 0x04000821 RID: 2081
		[Token(Token = "0x4000821")]
		[FieldOffset(Offset = "0x60")]
		[HideInInspector]
		[SerializeField]
		protected float m_TotalSplineLenght;

		// Token: 0x04000822 RID: 2082
		[Token(Token = "0x4000822")]
		[FieldOffset(Offset = "0x68")]
		public UnityEvent OnPathChanged;

		// Token: 0x04000823 RID: 2083
		[Token(Token = "0x4000823")]
		[FieldOffset(Offset = "0x70")]
		public PathControlPointEvent OnControlPointAdded;

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x78")]
		public PathControlPointEvent OnControlPointRemoved;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x80")]
		public PathControlPointEvent OnControlPointRenamed;
	}
}
