using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001FD RID: 509
	[Token(Token = "0x20001FD")]
	public struct Segment3d : IParametricCurve3d
	{
		// Token: 0x060010B2 RID: 4274 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010B2")]
		[Address(RVA = "0x1E47AD0", Offset = "0x1E460D0", VA = "0x181E47AD0")]
		public Segment3d(Vector3d p0, Vector3d p1)
		{
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010B3")]
		[Address(RVA = "0x1E47BD0", Offset = "0x1E461D0", VA = "0x181E47BD0")]
		public Segment3d(Vector3d center, Vector3d direction, double extent)
		{
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010B4")]
		[Address(RVA = "0x1E47C00", Offset = "0x1E46200", VA = "0x181E47C00")]
		public void SetEndpoints(Vector3d p0, Vector3d p1)
		{
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x060010B5 RID: 4277 RVA: 0x0000CAAC File Offset: 0x0000ACAC
		// (set) Token: 0x060010B6 RID: 4278 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A8")]
		public Vector3d P0
		{
			[Token(Token = "0x60010B5")]
			[Address(RVA = "0x1E47C50", Offset = "0x1E46250", VA = "0x181E47C50")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x60010B6")]
			[Address(RVA = "0x1E47D20", Offset = "0x1E46320", VA = "0x181E47D20")]
			set
			{
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x060010B7 RID: 4279 RVA: 0x0000CAC4 File Offset: 0x0000ACC4
		// (set) Token: 0x060010B8 RID: 4280 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002A9")]
		public Vector3d P1
		{
			[Token(Token = "0x60010B7")]
			[Address(RVA = "0x1E47D90", Offset = "0x1E46390", VA = "0x181E47D90")]
			get
			{
				return default(Vector3d);
			}
			[Token(Token = "0x60010B8")]
			[Address(RVA = "0x1E47E60", Offset = "0x1E46460", VA = "0x181E47E60")]
			set
			{
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x060010B9 RID: 4281 RVA: 0x0000CADC File Offset: 0x0000ACDC
		[Token(Token = "0x170002AA")]
		public double Length
		{
			[Token(Token = "0x60010B9")]
			[Address(RVA = "0x1E47EC0", Offset = "0x1E464C0", VA = "0x181E47EC0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x0000CAF4 File Offset: 0x0000ACF4
		[Token(Token = "0x60010BA")]
		[Address(RVA = "0x1E47ED0", Offset = "0x1E464D0", VA = "0x181E47ED0")]
		public Vector3d PointAt(double d)
		{
			return default(Vector3d);
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x0000CB0C File Offset: 0x0000AD0C
		[Token(Token = "0x60010BB")]
		[Address(RVA = "0x1E47FA0", Offset = "0x1E465A0", VA = "0x181E47FA0")]
		public Vector3d PointBetween(double t)
		{
			return default(Vector3d);
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x0000CB24 File Offset: 0x0000AD24
		[Token(Token = "0x60010BC")]
		[Address(RVA = "0x1E48090", Offset = "0x1E46690", VA = "0x181E48090")]
		public double DistanceSquared(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x0000CB3C File Offset: 0x0000AD3C
		[Token(Token = "0x60010BD")]
		[Address(RVA = "0x1E48270", Offset = "0x1E46870", VA = "0x181E48270")]
		public double DistanceSquared(Vector3d p, out double t)
		{
			return 0.0;
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x0000CB54 File Offset: 0x0000AD54
		[Token(Token = "0x60010BE")]
		[Address(RVA = "0x1E48470", Offset = "0x1E46A70", VA = "0x181E48470")]
		public Vector3d NearestPoint(Vector3d p)
		{
			return default(Vector3d);
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0000CB6C File Offset: 0x0000AD6C
		[Token(Token = "0x60010BF")]
		[Address(RVA = "0x1E48610", Offset = "0x1E46C10", VA = "0x181E48610")]
		public double Project(Vector3d p)
		{
			return 0.0;
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010C0")]
		[Address(RVA = "0x1E486C0", Offset = "0x1E46CC0", VA = "0x181E486C0")]
		private void update_from_endpoints(Vector3d p0, Vector3d p1)
		{
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0000CB84 File Offset: 0x0000AD84
		[Token(Token = "0x60010C1")]
		[Address(RVA = "0x1E487C0", Offset = "0x1E46DC0", VA = "0x181E487C0")]
		public static implicit operator Segment3d(Segment3f v)
		{
			return default(Segment3d);
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		[Token(Token = "0x60010C2")]
		[Address(RVA = "0x1E488B0", Offset = "0x1E46EB0", VA = "0x181E488B0")]
		public static explicit operator Segment3f(Segment3d v)
		{
			return default(Segment3f);
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x060010C3 RID: 4291 RVA: 0x0000CBB4 File Offset: 0x0000ADB4
		[Token(Token = "0x170002AB")]
		public bool IsClosed
		{
			[Token(Token = "0x60010C3")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x0000CBCC File Offset: 0x0000ADCC
		[Token(Token = "0x170002AC")]
		public double ParamLength
		{
			[Token(Token = "0x60010C4")]
			[Address(RVA = "0x1E46840", Offset = "0x1E44E40", VA = "0x181E46840", Slot = "5")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x0000CBE4 File Offset: 0x0000ADE4
		[Token(Token = "0x60010C5")]
		[Address(RVA = "0x1E489B0", Offset = "0x1E46FB0", VA = "0x181E489B0", Slot = "6")]
		public Vector3d SampleT(double t)
		{
			return default(Vector3d);
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		[Token(Token = "0x60010C6")]
		[Address(RVA = "0xF46E30", Offset = "0xF45430", VA = "0x180F46E30", Slot = "7")]
		public Vector3d TangentT(double t)
		{
			return default(Vector3d);
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060010C7 RID: 4295 RVA: 0x0000CC14 File Offset: 0x0000AE14
		[Token(Token = "0x170002AD")]
		public bool HasArcLength
		{
			[Token(Token = "0x60010C7")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x0000CC2C File Offset: 0x0000AE2C
		[Token(Token = "0x170002AE")]
		public double ArcLength
		{
			[Token(Token = "0x60010C8")]
			[Address(RVA = "0x1E47EC0", Offset = "0x1E464C0", VA = "0x181E47EC0", Slot = "9")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x0000CC44 File Offset: 0x0000AE44
		[Token(Token = "0x60010C9")]
		[Address(RVA = "0x1E48AA0", Offset = "0x1E470A0", VA = "0x181E48AA0", Slot = "10")]
		public Vector3d SampleArcLength(double a)
		{
			return default(Vector3d);
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60010CA")]
		[Address(RVA = "0x1E48B80", Offset = "0x1E47180", VA = "0x181E48B80", Slot = "11")]
		public void Reverse()
		{
		}

		// Token: 0x060010CB RID: 4299 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60010CB")]
		[Address(RVA = "0x1E48C10", Offset = "0x1E47210", VA = "0x181E48C10", Slot = "12")]
		public IParametricCurve3d Clone()
		{
			return null;
		}

		// Token: 0x04000827 RID: 2087
		[Token(Token = "0x4000827")]
		[FieldOffset(Offset = "0x0")]
		public Vector3d Center;

		// Token: 0x04000828 RID: 2088
		[Token(Token = "0x4000828")]
		[FieldOffset(Offset = "0x18")]
		public Vector3d Direction;

		// Token: 0x04000829 RID: 2089
		[Token(Token = "0x4000829")]
		[FieldOffset(Offset = "0x30")]
		public double Extent;
	}
}
