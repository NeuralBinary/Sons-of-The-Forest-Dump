using System;
using Il2CppDummyDll;
using UnityEngine;

namespace g3
{
	// Token: 0x0200020F RID: 527
	[Token(Token = "0x200020F")]
	public struct Vector3d : IComparable<Vector3d>, IEquatable<Vector3d>
	{
		// Token: 0x060011CD RID: 4557 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CD")]
		[Address(RVA = "0x1E712F0", Offset = "0x1E6F8F0", VA = "0x181E712F0")]
		public Vector3d(double f)
		{
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CE")]
		[Address(RVA = "0x5F9460", Offset = "0x5F7A60", VA = "0x1805F9460")]
		public Vector3d(double x, double y, double z)
		{
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011CF")]
		[Address(RVA = "0x1E71300", Offset = "0x1E6F900", VA = "0x181E71300")]
		public Vector3d(double[] v2)
		{
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D0")]
		[Address(RVA = "0x1E71350", Offset = "0x1E6F950", VA = "0x181E71350")]
		public Vector3d(Vector3d copy)
		{
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011D1")]
		[Address(RVA = "0x5F9470", Offset = "0x5F7A70", VA = "0x1805F9470")]
		public Vector3d(Vector3f copy)
		{
		}

		// Token: 0x170002D9 RID: 729
		[Token(Token = "0x170002D9")]
		public double this[int key]
		{
			[Token(Token = "0x60011D2")]
			[Address(RVA = "0x1E71370", Offset = "0x1E6F970", VA = "0x181E71370")]
			get
			{
				return 0.0;
			}
			[Token(Token = "0x60011D3")]
			[Address(RVA = "0x1E71390", Offset = "0x1E6F990", VA = "0x181E71390")]
			set
			{
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x060011D4 RID: 4564 RVA: 0x0000DBEC File Offset: 0x0000BDEC
		// (set) Token: 0x060011D5 RID: 4565 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002DA")]
		public Vector2d xy
		{
			[Token(Token = "0x60011D4")]
			[Address(RVA = "0x1E713B0", Offset = "0x1E6F9B0", VA = "0x181E713B0")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x60011D5")]
			[Address(RVA = "0x1E2F3F0", Offset = "0x1E2D9F0", VA = "0x181E2F3F0")]
			set
			{
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x0000DC04 File Offset: 0x0000BE04
		// (set) Token: 0x060011D7 RID: 4567 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002DB")]
		public Vector2d xz
		{
			[Token(Token = "0x60011D6")]
			[Address(RVA = "0x1E713D0", Offset = "0x1E6F9D0", VA = "0x181E713D0")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x60011D7")]
			[Address(RVA = "0x1E713F0", Offset = "0x1E6F9F0", VA = "0x181E713F0")]
			set
			{
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060011D8 RID: 4568 RVA: 0x0000DC1C File Offset: 0x0000BE1C
		// (set) Token: 0x060011D9 RID: 4569 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170002DC")]
		public Vector2d yz
		{
			[Token(Token = "0x60011D8")]
			[Address(RVA = "0x1E71400", Offset = "0x1E6FA00", VA = "0x181E71400")]
			get
			{
				return default(Vector2d);
			}
			[Token(Token = "0x60011D9")]
			[Address(RVA = "0x1E71420", Offset = "0x1E6FA20", VA = "0x181E71420")]
			set
			{
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060011DA RID: 4570 RVA: 0x0000DC34 File Offset: 0x0000BE34
		[Token(Token = "0x170002DD")]
		public double LengthSquared
		{
			[Token(Token = "0x60011DA")]
			[Address(RVA = "0x5F9270", Offset = "0x5F7870", VA = "0x1805F9270")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x060011DB RID: 4571 RVA: 0x0000DC4C File Offset: 0x0000BE4C
		[Token(Token = "0x170002DE")]
		public double Length
		{
			[Token(Token = "0x60011DB")]
			[Address(RVA = "0x1E71430", Offset = "0x1E6FA30", VA = "0x181E71430")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x060011DC RID: 4572 RVA: 0x0000DC64 File Offset: 0x0000BE64
		[Token(Token = "0x170002DF")]
		public double LengthL1
		{
			[Token(Token = "0x60011DC")]
			[Address(RVA = "0x1E714C0", Offset = "0x1E6FAC0", VA = "0x181E714C0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x060011DD RID: 4573 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		[Token(Token = "0x170002E0")]
		public double Max
		{
			[Token(Token = "0x60011DD")]
			[Address(RVA = "0x1E71540", Offset = "0x1E6FB40", VA = "0x181E71540")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x060011DE RID: 4574 RVA: 0x0000DC94 File Offset: 0x0000BE94
		[Token(Token = "0x170002E1")]
		public double Min
		{
			[Token(Token = "0x60011DE")]
			[Address(RVA = "0x1E71610", Offset = "0x1E6FC10", VA = "0x181E71610")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060011DF RID: 4575 RVA: 0x0000DCAC File Offset: 0x0000BEAC
		[Token(Token = "0x170002E2")]
		public double MaxAbs
		{
			[Token(Token = "0x60011DF")]
			[Address(RVA = "0x1E716E0", Offset = "0x1E6FCE0", VA = "0x181E716E0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060011E0 RID: 4576 RVA: 0x0000DCC4 File Offset: 0x0000BEC4
		[Token(Token = "0x170002E3")]
		public double MinAbs
		{
			[Token(Token = "0x60011E0")]
			[Address(RVA = "0x1E717B0", Offset = "0x1E6FDB0", VA = "0x181E717B0")]
			get
			{
				return 0.0;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060011E1 RID: 4577 RVA: 0x0000DCDC File Offset: 0x0000BEDC
		[Token(Token = "0x170002E4")]
		public Vector3d Abs
		{
			[Token(Token = "0x60011E1")]
			[Address(RVA = "0x1E71880", Offset = "0x1E6FE80", VA = "0x181E71880")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		[Token(Token = "0x60011E2")]
		[Address(RVA = "0x1E71900", Offset = "0x1E6FF00", VA = "0x181E71900")]
		public double Normalize(double epsilon = 2.220446049250313E-16)
		{
			return 0.0;
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x060011E3 RID: 4579 RVA: 0x0000DD0C File Offset: 0x0000BF0C
		[Token(Token = "0x170002E5")]
		public Vector3d Normalized
		{
			[Token(Token = "0x60011E3")]
			[Address(RVA = "0x1E71970", Offset = "0x1E6FF70", VA = "0x181E71970")]
			get
			{
				return default(Vector3d);
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x060011E4 RID: 4580 RVA: 0x0000DD24 File Offset: 0x0000BF24
		[Token(Token = "0x170002E6")]
		public bool IsNormalized
		{
			[Token(Token = "0x60011E4")]
			[Address(RVA = "0x1E71A30", Offset = "0x1E70030", VA = "0x181E71A30")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x060011E5 RID: 4581 RVA: 0x0000DD3C File Offset: 0x0000BF3C
		[Token(Token = "0x170002E7")]
		public bool IsFinite
		{
			[Token(Token = "0x60011E5")]
			[Address(RVA = "0x1E71AE0", Offset = "0x1E700E0", VA = "0x181E71AE0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011E6")]
		[Address(RVA = "0x1E71B30", Offset = "0x1E70130", VA = "0x181E71B30")]
		public void Round(int nDecimals)
		{
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x0000DD54 File Offset: 0x0000BF54
		[Token(Token = "0x60011E7")]
		[Address(RVA = "0x5F9B40", Offset = "0x5F8140", VA = "0x1805F9B40")]
		public double Dot(Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x0000DD6C File Offset: 0x0000BF6C
		[Token(Token = "0x60011E8")]
		[Address(RVA = "0x5F9B40", Offset = "0x5F8140", VA = "0x1805F9B40")]
		public double Dot(ref Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0000DD84 File Offset: 0x0000BF84
		[Token(Token = "0x60011E9")]
		[Address(RVA = "0x5F9B40", Offset = "0x5F8140", VA = "0x1805F9B40")]
		public static double Dot(Vector3d v1, Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x0000DD9C File Offset: 0x0000BF9C
		[Token(Token = "0x60011EA")]
		[Address(RVA = "0x1E71C70", Offset = "0x1E70270", VA = "0x181E71C70")]
		public Vector3d Cross(Vector3d v2)
		{
			return default(Vector3d);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0000DDB4 File Offset: 0x0000BFB4
		[Token(Token = "0x60011EB")]
		[Address(RVA = "0x1E71C70", Offset = "0x1E70270", VA = "0x181E71C70")]
		public Vector3d Cross(ref Vector3d v2)
		{
			return default(Vector3d);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0000DDCC File Offset: 0x0000BFCC
		[Token(Token = "0x60011EC")]
		[Address(RVA = "0x1E71CD0", Offset = "0x1E702D0", VA = "0x181E71CD0")]
		public static Vector3d Cross(Vector3d v1, Vector3d v2)
		{
			return default(Vector3d);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0000DDE4 File Offset: 0x0000BFE4
		[Token(Token = "0x60011ED")]
		[Address(RVA = "0x1E71D50", Offset = "0x1E70350", VA = "0x181E71D50")]
		public Vector3d UnitCross(ref Vector3d v2)
		{
			return default(Vector3d);
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		[Token(Token = "0x60011EE")]
		[Address(RVA = "0x1E71DE0", Offset = "0x1E703E0", VA = "0x181E71DE0")]
		public Vector3d UnitCross(Vector3d v2)
		{
			return default(Vector3d);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0000DE14 File Offset: 0x0000C014
		[Token(Token = "0x60011EF")]
		[Address(RVA = "0x1E71F40", Offset = "0x1E70540", VA = "0x181E71F40")]
		public double AngleD(Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0000DE2C File Offset: 0x0000C02C
		[Token(Token = "0x60011F0")]
		[Address(RVA = "0x1E72010", Offset = "0x1E70610", VA = "0x181E72010")]
		public static double AngleD(Vector3d v1, Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x0000DE44 File Offset: 0x0000C044
		[Token(Token = "0x60011F1")]
		[Address(RVA = "0x1E72040", Offset = "0x1E70640", VA = "0x181E72040")]
		public double AngleR(Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0000DE5C File Offset: 0x0000C05C
		[Token(Token = "0x60011F2")]
		[Address(RVA = "0x1E72110", Offset = "0x1E70710", VA = "0x181E72110")]
		public static double AngleR(Vector3d v1, Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x0000DE74 File Offset: 0x0000C074
		[Token(Token = "0x60011F3")]
		[Address(RVA = "0x1E72140", Offset = "0x1E70740", VA = "0x181E72140")]
		public double DistanceSquared(Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0000DE8C File Offset: 0x0000C08C
		[Token(Token = "0x60011F4")]
		[Address(RVA = "0x1E72180", Offset = "0x1E70780", VA = "0x181E72180")]
		public double DistanceSquared(ref Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011F5 RID: 4597 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
		[Token(Token = "0x60011F5")]
		[Address(RVA = "0x1E721C0", Offset = "0x1E707C0", VA = "0x181E721C0")]
		public double Distance(Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011F6 RID: 4598 RVA: 0x0000DEBC File Offset: 0x0000C0BC
		[Token(Token = "0x60011F6")]
		[Address(RVA = "0x1E72280", Offset = "0x1E70880", VA = "0x181E72280")]
		public double Distance(ref Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x060011F7 RID: 4599 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011F7")]
		[Address(RVA = "0x1E71350", Offset = "0x1E6F950", VA = "0x181E71350")]
		public void Set(Vector3d o)
		{
		}

		// Token: 0x060011F8 RID: 4600 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011F8")]
		[Address(RVA = "0x5F9460", Offset = "0x5F7A60", VA = "0x1805F9460")]
		public void Set(double fX, double fY, double fZ)
		{
		}

		// Token: 0x060011F9 RID: 4601 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011F9")]
		[Address(RVA = "0x1E72340", Offset = "0x1E70940", VA = "0x181E72340")]
		public void Add(Vector3d o)
		{
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60011FA")]
		[Address(RVA = "0x1E72370", Offset = "0x1E70970", VA = "0x181E72370")]
		public void Subtract(Vector3d o)
		{
		}

		// Token: 0x060011FB RID: 4603 RVA: 0x0000DED4 File Offset: 0x0000C0D4
		[Token(Token = "0x60011FB")]
		[Address(RVA = "0x5F9580", Offset = "0x5F7B80", VA = "0x1805F9580")]
		public static Vector3d operator -(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x060011FC RID: 4604 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		[Token(Token = "0x60011FC")]
		[Address(RVA = "0x5F9540", Offset = "0x5F7B40", VA = "0x1805F9540")]
		public static Vector3d operator *(double f, Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x060011FD RID: 4605 RVA: 0x0000DF04 File Offset: 0x0000C104
		[Token(Token = "0x60011FD")]
		[Address(RVA = "0x5F9520", Offset = "0x5F7B20", VA = "0x1805F9520")]
		public static Vector3d operator *(Vector3d v, double f)
		{
			return default(Vector3d);
		}

		// Token: 0x060011FE RID: 4606 RVA: 0x0000DF1C File Offset: 0x0000C11C
		[Token(Token = "0x60011FE")]
		[Address(RVA = "0x5F9560", Offset = "0x5F7B60", VA = "0x1805F9560")]
		public static Vector3d operator /(Vector3d v, double f)
		{
			return default(Vector3d);
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0000DF34 File Offset: 0x0000C134
		[Token(Token = "0x60011FF")]
		[Address(RVA = "0x1E723A0", Offset = "0x1E709A0", VA = "0x181E723A0")]
		public static Vector3d operator /(double f, Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0000DF4C File Offset: 0x0000C14C
		[Token(Token = "0x6001200")]
		[Address(RVA = "0x1E723D0", Offset = "0x1E709D0", VA = "0x181E723D0")]
		public static Vector3d operator *(Vector3d a, Vector3d b)
		{
			return default(Vector3d);
		}

		// Token: 0x06001201 RID: 4609 RVA: 0x0000DF64 File Offset: 0x0000C164
		[Token(Token = "0x6001201")]
		[Address(RVA = "0x1E72410", Offset = "0x1E70A10", VA = "0x181E72410")]
		public static Vector3d operator /(Vector3d a, Vector3d b)
		{
			return default(Vector3d);
		}

		// Token: 0x06001202 RID: 4610 RVA: 0x0000DF7C File Offset: 0x0000C17C
		[Token(Token = "0x6001202")]
		[Address(RVA = "0x5F94A0", Offset = "0x5F7AA0", VA = "0x1805F94A0")]
		public static Vector3d operator +(Vector3d v0, Vector3d v1)
		{
			return default(Vector3d);
		}

		// Token: 0x06001203 RID: 4611 RVA: 0x0000DF94 File Offset: 0x0000C194
		[Token(Token = "0x6001203")]
		[Address(RVA = "0x1E72450", Offset = "0x1E70A50", VA = "0x181E72450")]
		public static Vector3d operator +(Vector3d v0, double f)
		{
			return default(Vector3d);
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0000DFAC File Offset: 0x0000C1AC
		[Token(Token = "0x6001204")]
		[Address(RVA = "0x5F94E0", Offset = "0x5F7AE0", VA = "0x1805F94E0")]
		public static Vector3d operator -(Vector3d v0, Vector3d v1)
		{
			return default(Vector3d);
		}

		// Token: 0x06001205 RID: 4613 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
		[Token(Token = "0x6001205")]
		[Address(RVA = "0x1E72470", Offset = "0x1E70A70", VA = "0x181E72470")]
		public static Vector3d operator -(Vector3d v0, double f)
		{
			return default(Vector3d);
		}

		// Token: 0x06001206 RID: 4614 RVA: 0x0000DFDC File Offset: 0x0000C1DC
		[Token(Token = "0x6001206")]
		[Address(RVA = "0x1E72490", Offset = "0x1E70A90", VA = "0x181E72490")]
		public static bool operator ==(Vector3d a, Vector3d b)
		{
			return default(bool);
		}

		// Token: 0x06001207 RID: 4615 RVA: 0x0000DFF4 File Offset: 0x0000C1F4
		[Token(Token = "0x6001207")]
		[Address(RVA = "0x1E724D0", Offset = "0x1E70AD0", VA = "0x181E724D0")]
		public static bool operator !=(Vector3d a, Vector3d b)
		{
			return default(bool);
		}

		// Token: 0x06001208 RID: 4616 RVA: 0x0000E00C File Offset: 0x0000C20C
		[Token(Token = "0x6001208")]
		[Address(RVA = "0x1E72510", Offset = "0x1E70B10", VA = "0x181E72510", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001209 RID: 4617 RVA: 0x0000E024 File Offset: 0x0000C224
		[Token(Token = "0x6001209")]
		[Address(RVA = "0x1E725F0", Offset = "0x1E70BF0", VA = "0x181E725F0", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600120A RID: 4618 RVA: 0x0000E03C File Offset: 0x0000C23C
		[Token(Token = "0x600120A")]
		[Address(RVA = "0x1E726A0", Offset = "0x1E70CA0", VA = "0x181E726A0", Slot = "4")]
		public int CompareTo(Vector3d other)
		{
			return 0;
		}

		// Token: 0x0600120B RID: 4619 RVA: 0x0000E054 File Offset: 0x0000C254
		[Token(Token = "0x600120B")]
		[Address(RVA = "0x5F9990", Offset = "0x5F7F90", VA = "0x1805F9990", Slot = "5")]
		public bool Equals(Vector3d other)
		{
			return default(bool);
		}

		// Token: 0x0600120C RID: 4620 RVA: 0x0000E06C File Offset: 0x0000C26C
		[Token(Token = "0x600120C")]
		[Address(RVA = "0x1E72720", Offset = "0x1E70D20", VA = "0x181E72720")]
		public bool EpsilonEqual(Vector3d v2, double epsilon)
		{
			return default(bool);
		}

		// Token: 0x0600120D RID: 4621 RVA: 0x0000E084 File Offset: 0x0000C284
		[Token(Token = "0x600120D")]
		[Address(RVA = "0x1E72830", Offset = "0x1E70E30", VA = "0x181E72830")]
		public static Vector3d Lerp(Vector3d a, Vector3d b, double t)
		{
			return default(Vector3d);
		}

		// Token: 0x0600120E RID: 4622 RVA: 0x0000E09C File Offset: 0x0000C29C
		[Token(Token = "0x600120E")]
		[Address(RVA = "0x1E728C0", Offset = "0x1E70EC0", VA = "0x181E728C0")]
		public static Vector3d Lerp(ref Vector3d a, ref Vector3d b, double t)
		{
			return default(Vector3d);
		}

		// Token: 0x0600120F RID: 4623 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600120F")]
		[Address(RVA = "0x1E72920", Offset = "0x1E70F20", VA = "0x181E72920", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06001210 RID: 4624 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6001210")]
		[Address(RVA = "0x1E729F0", Offset = "0x1E70FF0", VA = "0x181E729F0")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x06001211 RID: 4625 RVA: 0x0000E0B4 File Offset: 0x0000C2B4
		[Token(Token = "0x6001211")]
		[Address(RVA = "0x5F96E0", Offset = "0x5F7CE0", VA = "0x1805F96E0")]
		public static implicit operator Vector3d(Vector3f v)
		{
			return default(Vector3d);
		}

		// Token: 0x06001212 RID: 4626 RVA: 0x0000E0CC File Offset: 0x0000C2CC
		[Token(Token = "0x6001212")]
		[Address(RVA = "0x5F9710", Offset = "0x5F7D10", VA = "0x1805F9710")]
		public static explicit operator Vector3f(Vector3d v)
		{
			return default(Vector3f);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
		[Token(Token = "0x6001213")]
		[Address(RVA = "0x5F96E0", Offset = "0x5F7CE0", VA = "0x1805F96E0")]
		public static implicit operator Vector3d(Vector3 v)
		{
			return default(Vector3d);
		}

		// Token: 0x06001214 RID: 4628 RVA: 0x0000E0FC File Offset: 0x0000C2FC
		[Token(Token = "0x6001214")]
		[Address(RVA = "0x5F9710", Offset = "0x5F7D10", VA = "0x1805F9710")]
		public static explicit operator Vector3(Vector3d v)
		{
			return default(Vector3);
		}

		// Token: 0x06001215 RID: 4629 RVA: 0x0000E114 File Offset: 0x0000C314
		[Token(Token = "0x6001215")]
		[Address(RVA = "0x1E72A90", Offset = "0x1E71090", VA = "0x181E72A90")]
		public static double Orthonormalize(ref Vector3d u, ref Vector3d v, ref Vector3d w)
		{
			return 0.0;
		}

		// Token: 0x06001216 RID: 4630 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001216")]
		[Address(RVA = "0x1E72CE0", Offset = "0x1E712E0", VA = "0x181E72CE0")]
		public static void GenerateComplementBasis(ref Vector3d u, ref Vector3d v, Vector3d w)
		{
		}

		// Token: 0x06001217 RID: 4631 RVA: 0x0000E12C File Offset: 0x0000C32C
		[Token(Token = "0x6001217")]
		[Address(RVA = "0x1E72EF0", Offset = "0x1E714F0", VA = "0x181E72EF0")]
		public static double ComputeOrthogonalComplement(int numInputs, Vector3d v0, ref Vector3d v1, ref Vector3d v2)
		{
			return 0.0;
		}

		// Token: 0x06001218 RID: 4632 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001218")]
		[Address(RVA = "0x1E73090", Offset = "0x1E71690", VA = "0x181E73090")]
		public static void MakePerpVectors(ref Vector3d n, out Vector3d b1, out Vector3d b2)
		{
		}

		// Token: 0x04000874 RID: 2164
		[Token(Token = "0x4000874")]
		[FieldOffset(Offset = "0x0")]
		public double x;

		// Token: 0x04000875 RID: 2165
		[Token(Token = "0x4000875")]
		[FieldOffset(Offset = "0x8")]
		public double y;

		// Token: 0x04000876 RID: 2166
		[Token(Token = "0x4000876")]
		[FieldOffset(Offset = "0x10")]
		public double z;

		// Token: 0x04000877 RID: 2167
		[Token(Token = "0x4000877")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3d Zero;

		// Token: 0x04000878 RID: 2168
		[Token(Token = "0x4000878")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Vector3d One;

		// Token: 0x04000879 RID: 2169
		[Token(Token = "0x4000879")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Vector3d AxisX;

		// Token: 0x0400087A RID: 2170
		[Token(Token = "0x400087A")]
		[FieldOffset(Offset = "0x48")]
		public static readonly Vector3d AxisY;

		// Token: 0x0400087B RID: 2171
		[Token(Token = "0x400087B")]
		[FieldOffset(Offset = "0x60")]
		public static readonly Vector3d AxisZ;

		// Token: 0x0400087C RID: 2172
		[Token(Token = "0x400087C")]
		[FieldOffset(Offset = "0x78")]
		public static readonly Vector3d MaxValue;

		// Token: 0x0400087D RID: 2173
		[Token(Token = "0x400087D")]
		[FieldOffset(Offset = "0x90")]
		public static readonly Vector3d MinValue;
	}
}
