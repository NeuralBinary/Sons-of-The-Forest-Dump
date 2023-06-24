using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000211 RID: 529
	[Token(Token = "0x2000211")]
	public struct Vector3i : IComparable<Vector3i>, IEquatable<Vector3i>
	{
		// Token: 0x0600125F RID: 4703 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x600125F")]
		[Address(RVA = "0x1E2A530", Offset = "0x1E28B30", VA = "0x181E2A530")]
		public Vector3i(int f)
		{
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001260")]
		[Address(RVA = "0x65F570", Offset = "0x65DB70", VA = "0x18065F570")]
		public Vector3i(int x, int y, int z)
		{
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001261")]
		[Address(RVA = "0x1E2A540", Offset = "0x1E28B40", VA = "0x181E2A540")]
		public Vector3i(int[] v2)
		{
		}

		// Token: 0x170002F6 RID: 758
		[Token(Token = "0x170002F6")]
		public int this[int key]
		{
			[Token(Token = "0x6001262")]
			[Address(RVA = "0x65F9B0", Offset = "0x65DFB0", VA = "0x18065F9B0")]
			get
			{
				return 0;
			}
			[Token(Token = "0x6001263")]
			[Address(RVA = "0x65F9D0", Offset = "0x65DFD0", VA = "0x18065F9D0")]
			set
			{
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x170002F7")]
		public int[] array
		{
			[Token(Token = "0x6001264")]
			[Address(RVA = "0x1E74B40", Offset = "0x1E73140", VA = "0x181E74B40")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001265")]
		[Address(RVA = "0x1E732C0", Offset = "0x1E718C0", VA = "0x181E732C0")]
		public void Set(Vector3i o)
		{
		}

		// Token: 0x06001266 RID: 4710 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001266")]
		[Address(RVA = "0x65F570", Offset = "0x65DB70", VA = "0x18065F570")]
		public void Set(int fX, int fY, int fZ)
		{
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001267")]
		[Address(RVA = "0x1E74BB0", Offset = "0x1E731B0", VA = "0x181E74BB0")]
		public void Add(Vector3i o)
		{
		}

		// Token: 0x06001268 RID: 4712 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001268")]
		[Address(RVA = "0x1E74BD0", Offset = "0x1E731D0", VA = "0x181E74BD0")]
		public void Subtract(Vector3i o)
		{
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6001269")]
		[Address(RVA = "0x1E74BF0", Offset = "0x1E731F0", VA = "0x181E74BF0")]
		public void Add(int s)
		{
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0000E5F4 File Offset: 0x0000C7F4
		[Token(Token = "0x170002F8")]
		public int LengthSquared
		{
			[Token(Token = "0x600126A")]
			[Address(RVA = "0x1E2A620", Offset = "0x1E28C20", VA = "0x181E2A620")]
			get
			{
				return 0;
			}
		}

		// Token: 0x0600126B RID: 4715 RVA: 0x0000E60C File Offset: 0x0000C80C
		[Token(Token = "0x600126B")]
		[Address(RVA = "0x1E2A6E0", Offset = "0x1E28CE0", VA = "0x181E2A6E0")]
		public static Vector3i operator -(Vector3i v)
		{
			return default(Vector3i);
		}

		// Token: 0x0600126C RID: 4716 RVA: 0x0000E624 File Offset: 0x0000C824
		[Token(Token = "0x600126C")]
		[Address(RVA = "0x1E2A700", Offset = "0x1E28D00", VA = "0x181E2A700")]
		public static Vector3i operator *(int f, Vector3i v)
		{
			return default(Vector3i);
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0000E63C File Offset: 0x0000C83C
		[Token(Token = "0x600126D")]
		[Address(RVA = "0x1E2A720", Offset = "0x1E28D20", VA = "0x181E2A720")]
		public static Vector3i operator *(Vector3i v, int f)
		{
			return default(Vector3i);
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0000E654 File Offset: 0x0000C854
		[Token(Token = "0x600126E")]
		[Address(RVA = "0x1E2A740", Offset = "0x1E28D40", VA = "0x181E2A740")]
		public static Vector3i operator /(Vector3i v, int f)
		{
			return default(Vector3i);
		}

		// Token: 0x0600126F RID: 4719 RVA: 0x0000E66C File Offset: 0x0000C86C
		[Token(Token = "0x600126F")]
		[Address(RVA = "0x1E74C00", Offset = "0x1E73200", VA = "0x181E74C00")]
		public static Vector3i operator /(int f, Vector3i v)
		{
			return default(Vector3i);
		}

		// Token: 0x06001270 RID: 4720 RVA: 0x0000E684 File Offset: 0x0000C884
		[Token(Token = "0x6001270")]
		[Address(RVA = "0x1E2A770", Offset = "0x1E28D70", VA = "0x181E2A770")]
		public static Vector3i operator *(Vector3i a, Vector3i b)
		{
			return default(Vector3i);
		}

		// Token: 0x06001271 RID: 4721 RVA: 0x0000E69C File Offset: 0x0000C89C
		[Token(Token = "0x6001271")]
		[Address(RVA = "0x1E2A7A0", Offset = "0x1E28DA0", VA = "0x181E2A7A0")]
		public static Vector3i operator /(Vector3i a, Vector3i b)
		{
			return default(Vector3i);
		}

		// Token: 0x06001272 RID: 4722 RVA: 0x0000E6B4 File Offset: 0x0000C8B4
		[Token(Token = "0x6001272")]
		[Address(RVA = "0x1E2A7D0", Offset = "0x1E28DD0", VA = "0x181E2A7D0")]
		public static Vector3i operator +(Vector3i v0, Vector3i v1)
		{
			return default(Vector3i);
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0000E6CC File Offset: 0x0000C8CC
		[Token(Token = "0x6001273")]
		[Address(RVA = "0x1E2A7F0", Offset = "0x1E28DF0", VA = "0x181E2A7F0")]
		public static Vector3i operator +(Vector3i v0, int f)
		{
			return default(Vector3i);
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0000E6E4 File Offset: 0x0000C8E4
		[Token(Token = "0x6001274")]
		[Address(RVA = "0x1E2A820", Offset = "0x1E28E20", VA = "0x181E2A820")]
		public static Vector3i operator -(Vector3i v0, Vector3i v1)
		{
			return default(Vector3i);
		}

		// Token: 0x06001275 RID: 4725 RVA: 0x0000E6FC File Offset: 0x0000C8FC
		[Token(Token = "0x6001275")]
		[Address(RVA = "0x1E2A840", Offset = "0x1E28E40", VA = "0x181E2A840")]
		public static Vector3i operator -(Vector3i v0, int f)
		{
			return default(Vector3i);
		}

		// Token: 0x06001276 RID: 4726 RVA: 0x0000E714 File Offset: 0x0000C914
		[Token(Token = "0x6001276")]
		[Address(RVA = "0x65F580", Offset = "0x65DB80", VA = "0x18065F580")]
		public static bool operator ==(Vector3i a, Vector3i b)
		{
			return default(bool);
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0000E72C File Offset: 0x0000C92C
		[Token(Token = "0x6001277")]
		[Address(RVA = "0x65F5A0", Offset = "0x65DBA0", VA = "0x18065F5A0")]
		public static bool operator !=(Vector3i a, Vector3i b)
		{
			return default(bool);
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0000E744 File Offset: 0x0000C944
		[Token(Token = "0x6001278")]
		[Address(RVA = "0x1E74C30", Offset = "0x1E73230", VA = "0x181E74C30", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		// Token: 0x06001279 RID: 4729 RVA: 0x0000E75C File Offset: 0x0000C95C
		[Token(Token = "0x6001279")]
		[Address(RVA = "0x1E2A930", Offset = "0x1E28F30", VA = "0x181E2A930", Slot = "2")]
		public override int GetHashCode()
		{
			return 0;
		}

		// Token: 0x0600127A RID: 4730 RVA: 0x0000E774 File Offset: 0x0000C974
		[Token(Token = "0x600127A")]
		[Address(RVA = "0x1E2A950", Offset = "0x1E28F50", VA = "0x181E2A950", Slot = "4")]
		public int CompareTo(Vector3i other)
		{
			return 0;
		}

		// Token: 0x0600127B RID: 4731 RVA: 0x0000E78C File Offset: 0x0000C98C
		[Token(Token = "0x600127B")]
		[Address(RVA = "0x65F580", Offset = "0x65DB80", VA = "0x18065F580", Slot = "5")]
		public bool Equals(Vector3i other)
		{
			return default(bool);
		}

		// Token: 0x0600127C RID: 4732 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x600127C")]
		[Address(RVA = "0x1E74D00", Offset = "0x1E73300", VA = "0x181E74D00", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		[Token(Token = "0x600127D")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static implicit operator Vector3i(Index3i v)
		{
			return default(Vector3i);
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0000E7BC File Offset: 0x0000C9BC
		[Token(Token = "0x600127E")]
		[Address(RVA = "0xA60D20", Offset = "0xA5F320", VA = "0x180A60D20")]
		public static implicit operator Index3i(Vector3i v)
		{
			return default(Index3i);
		}

		// Token: 0x0600127F RID: 4735 RVA: 0x0000E7D4 File Offset: 0x0000C9D4
		[Token(Token = "0x600127F")]
		[Address(RVA = "0xAE6050", Offset = "0xAE4650", VA = "0x180AE6050")]
		public static explicit operator Vector3i(Vector3f v)
		{
			return default(Vector3i);
		}

		// Token: 0x06001280 RID: 4736 RVA: 0x0000E7EC File Offset: 0x0000C9EC
		[Token(Token = "0x6001280")]
		[Address(RVA = "0x1E74DC0", Offset = "0x1E733C0", VA = "0x181E74DC0")]
		public static explicit operator Vector3f(Vector3i v)
		{
			return default(Vector3f);
		}

		// Token: 0x06001281 RID: 4737 RVA: 0x0000E804 File Offset: 0x0000CA04
		[Token(Token = "0x6001281")]
		[Address(RVA = "0x1E74DF0", Offset = "0x1E733F0", VA = "0x181E74DF0")]
		public static explicit operator Vector3i(Vector3d v)
		{
			return default(Vector3i);
		}

		// Token: 0x06001282 RID: 4738 RVA: 0x0000E81C File Offset: 0x0000CA1C
		[Token(Token = "0x6001282")]
		[Address(RVA = "0x1E74E10", Offset = "0x1E73410", VA = "0x181E74E10")]
		public static explicit operator Vector3d(Vector3i v)
		{
			return default(Vector3d);
		}

		// Token: 0x0400088A RID: 2186
		[Token(Token = "0x400088A")]
		[FieldOffset(Offset = "0x0")]
		public int x;

		// Token: 0x0400088B RID: 2187
		[Token(Token = "0x400088B")]
		[FieldOffset(Offset = "0x4")]
		public int y;

		// Token: 0x0400088C RID: 2188
		[Token(Token = "0x400088C")]
		[FieldOffset(Offset = "0x8")]
		public int z;

		// Token: 0x0400088D RID: 2189
		[Token(Token = "0x400088D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Vector3i Zero;

		// Token: 0x0400088E RID: 2190
		[Token(Token = "0x400088E")]
		[FieldOffset(Offset = "0xC")]
		public static readonly Vector3i One;

		// Token: 0x0400088F RID: 2191
		[Token(Token = "0x400088F")]
		[FieldOffset(Offset = "0x18")]
		public static readonly Vector3i AxisX;

		// Token: 0x04000890 RID: 2192
		[Token(Token = "0x4000890")]
		[FieldOffset(Offset = "0x24")]
		public static readonly Vector3i AxisY;

		// Token: 0x04000891 RID: 2193
		[Token(Token = "0x4000891")]
		[FieldOffset(Offset = "0x30")]
		public static readonly Vector3i AxisZ;
	}
}
