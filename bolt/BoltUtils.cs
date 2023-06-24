using System;
using System.Collections.Generic;
using System.Text;
using Bolt;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

// Token: 0x0200003F RID: 63
[Token(Token = "0x200003F")]
[Documentation(Ignore = true)]
public static class BoltUtils
{
	// Token: 0x06000281 RID: 641 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000281")]
	[Address(RVA = "0x79F060", Offset = "0x79D660", VA = "0x18079F060")]
	public static string ToStringDetailed(this Quaternion q)
	{
		return null;
	}

	// Token: 0x06000282 RID: 642 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000282")]
	[Address(RVA = "0x79F260", Offset = "0x79D860", VA = "0x18079F260")]
	public static IProtocolToken GetProtocolToken(this UdpSession session)
	{
		return null;
	}

	// Token: 0x06000283 RID: 643 RVA: 0x00002CB8 File Offset: 0x00000EB8
	[Token(Token = "0x6000283")]
	[Address(RVA = "0x79F310", Offset = "0x79D910", VA = "0x18079F310")]
	public static bool NullOrEmpty(this Array array)
	{
		return default(bool);
	}

	// Token: 0x06000284 RID: 644 RVA: 0x00002CD0 File Offset: 0x00000ED0
	[Token(Token = "0x6000284")]
	public static bool Has<T>(this T[] array, int index) where T : class
	{
		return default(bool);
	}

	// Token: 0x06000285 RID: 645 RVA: 0x00002CE8 File Offset: 0x00000EE8
	[Token(Token = "0x6000285")]
	public static bool Has<T>(this T[] array, uint index) where T : class
	{
		return default(bool);
	}

	// Token: 0x06000286 RID: 646 RVA: 0x00002D00 File Offset: 0x00000F00
	[Token(Token = "0x6000286")]
	public static bool TryGetIndex<T>(this T[] array, int index, out T value) where T : class
	{
		return default(bool);
	}

	// Token: 0x06000287 RID: 647 RVA: 0x00002D18 File Offset: 0x00000F18
	[Token(Token = "0x6000287")]
	public static bool TryGetIndex<T>(this T[] array, uint index, out T value) where T : class
	{
		return default(bool);
	}

	// Token: 0x06000288 RID: 648 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000288")]
	public static T FindComponent<T>(this Component component) where T : Component
	{
		return null;
	}

	// Token: 0x06000289 RID: 649 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000289")]
	public static T FindComponent<T>(this GameObject gameObject) where T : Component
	{
		return null;
	}

	// Token: 0x0600028A RID: 650 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600028A")]
	public static T FindComponent<T>(this Transform transform) where T : Component
	{
		return null;
	}

	// Token: 0x0600028B RID: 651 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600028B")]
	[Address(RVA = "0x79F340", Offset = "0x79D940", VA = "0x18079F340")]
	public static BoltConnection GetBoltConnection(this UdpConnection self)
	{
		return null;
	}

	// Token: 0x0600028C RID: 652 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600028C")]
	public static string Join<T>(this IEnumerable<T> items, string seperator)
	{
		return null;
	}

	// Token: 0x0600028D RID: 653 RVA: 0x00002D30 File Offset: 0x00000F30
	[Token(Token = "0x600028D")]
	[Address(RVA = "0x79F3C0", Offset = "0x79D9C0", VA = "0x18079F3C0")]
	public static bool ViewPointIsOnScreen(this Vector3 vp)
	{
		return default(bool);
	}

	// Token: 0x0600028E RID: 654 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600028E")]
	public static T[] CloneArray<T>(this T[] array)
	{
		return null;
	}

	// Token: 0x0600028F RID: 655 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x600028F")]
	public static T[] AddFirst<T>(this T[] array, T item)
	{
		return null;
	}

	// Token: 0x06000290 RID: 656 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000290")]
	[Address(RVA = "0x79F400", Offset = "0x79DA00", VA = "0x18079F400")]
	public static void WriteUniqueId(this UdpPacket stream, UniqueId id)
	{
	}

	// Token: 0x06000291 RID: 657 RVA: 0x00002D48 File Offset: 0x00000F48
	[Token(Token = "0x6000291")]
	[Address(RVA = "0x79F470", Offset = "0x79DA70", VA = "0x18079F470")]
	public static UniqueId ReadUniqueId(this UdpPacket stream)
	{
		return default(UniqueId);
	}

	// Token: 0x06000292 RID: 658 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000292")]
	[Address(RVA = "0x79F4F0", Offset = "0x79DAF0", VA = "0x18079F4F0")]
	public static void WriteByteArraySimple(this UdpPacket stream, byte[] array, int maxLength)
	{
	}

	// Token: 0x06000293 RID: 659 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x6000293")]
	[Address(RVA = "0x79F580", Offset = "0x79DB80", VA = "0x18079F580")]
	public static byte[] ReadByteArraySimple(this UdpPacket stream)
	{
		return null;
	}

	// Token: 0x06000294 RID: 660 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000294")]
	[Address(RVA = "0x79F650", Offset = "0x79DC50", VA = "0x18079F650")]
	public static void WriteColor32RGBA(this UdpPacket stream, Color32 value)
	{
	}

	// Token: 0x06000295 RID: 661 RVA: 0x00002D60 File Offset: 0x00000F60
	[Token(Token = "0x6000295")]
	[Address(RVA = "0x79F700", Offset = "0x79DD00", VA = "0x18079F700")]
	public static Color32 ReadColor32RGBA(this UdpPacket stream)
	{
		return default(Color32);
	}

	// Token: 0x06000296 RID: 662 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000296")]
	[Address(RVA = "0x79F790", Offset = "0x79DD90", VA = "0x18079F790")]
	public static void WriteColor32RGB(this UdpPacket stream, Color32 value)
	{
	}

	// Token: 0x06000297 RID: 663 RVA: 0x00002D78 File Offset: 0x00000F78
	[Token(Token = "0x6000297")]
	[Address(RVA = "0x79F820", Offset = "0x79DE20", VA = "0x18079F820")]
	public static Color32 ReadColor32RGB(this UdpPacket stream)
	{
		return default(Color32);
	}

	// Token: 0x06000298 RID: 664 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x6000298")]
	[Address(RVA = "0x79F890", Offset = "0x79DE90", VA = "0x18079F890")]
	public static void WriteVector2(this UdpPacket stream, Vector2 value)
	{
	}

	// Token: 0x06000299 RID: 665 RVA: 0x00002D90 File Offset: 0x00000F90
	[Token(Token = "0x6000299")]
	[Address(RVA = "0x79F8D0", Offset = "0x79DED0", VA = "0x18079F8D0")]
	public static Vector2 ReadVector2(this UdpPacket stream)
	{
		return default(Vector2);
	}

	// Token: 0x0600029A RID: 666 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029A")]
	[Address(RVA = "0x79F920", Offset = "0x79DF20", VA = "0x18079F920")]
	public static void WriteVector3(this UdpPacket stream, Vector3 value)
	{
	}

	// Token: 0x0600029B RID: 667 RVA: 0x00002DA8 File Offset: 0x00000FA8
	[Token(Token = "0x600029B")]
	[Address(RVA = "0x79F980", Offset = "0x79DF80", VA = "0x18079F980")]
	public static Vector3 ReadVector3(this UdpPacket stream)
	{
		return default(Vector3);
	}

	// Token: 0x0600029C RID: 668 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029C")]
	[Address(RVA = "0x79F920", Offset = "0x79DF20", VA = "0x18079F920")]
	public static void WriteColorRGB(this UdpPacket stream, Color value)
	{
	}

	// Token: 0x0600029D RID: 669 RVA: 0x00002DC0 File Offset: 0x00000FC0
	[Token(Token = "0x600029D")]
	[Address(RVA = "0x79F9F0", Offset = "0x79DFF0", VA = "0x18079F9F0")]
	public static Color ReadColorRGB(this UdpPacket stream)
	{
		return default(Color);
	}

	// Token: 0x0600029E RID: 670 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x600029E")]
	[Address(RVA = "0x79FA70", Offset = "0x79E070", VA = "0x18079FA70")]
	public static void WriteVector4(this UdpPacket stream, Vector4 value)
	{
	}

	// Token: 0x0600029F RID: 671 RVA: 0x00002DD8 File Offset: 0x00000FD8
	[Token(Token = "0x600029F")]
	[Address(RVA = "0x79FAE0", Offset = "0x79E0E0", VA = "0x18079FAE0")]
	public static Vector4 ReadVector4(this UdpPacket stream)
	{
		return default(Vector4);
	}

	// Token: 0x060002A0 RID: 672 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A0")]
	[Address(RVA = "0x79FA70", Offset = "0x79E070", VA = "0x18079FA70")]
	public static void WriteColorRGBA(this UdpPacket stream, Color value)
	{
	}

	// Token: 0x060002A1 RID: 673 RVA: 0x00002DF0 File Offset: 0x00000FF0
	[Token(Token = "0x60002A1")]
	[Address(RVA = "0x79FAE0", Offset = "0x79E0E0", VA = "0x18079FAE0")]
	public static Color ReadColorRGBA(this UdpPacket stream)
	{
		return default(Color);
	}

	// Token: 0x060002A2 RID: 674 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A2")]
	[Address(RVA = "0x79FA70", Offset = "0x79E070", VA = "0x18079FA70")]
	public static void WriteQuaternion(this UdpPacket stream, Quaternion value)
	{
	}

	// Token: 0x060002A3 RID: 675 RVA: 0x00002E08 File Offset: 0x00001008
	[Token(Token = "0x60002A3")]
	[Address(RVA = "0x79FAE0", Offset = "0x79E0E0", VA = "0x18079FAE0")]
	public static Quaternion ReadQuaternion(this UdpPacket stream)
	{
		return default(Quaternion);
	}

	// Token: 0x060002A4 RID: 676 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A4")]
	[Address(RVA = "0x79FB70", Offset = "0x79E170", VA = "0x18079FB70")]
	public static void WriteTransform(this UdpPacket stream, Transform transform)
	{
	}

	// Token: 0x060002A5 RID: 677 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A5")]
	[Address(RVA = "0x79FCC0", Offset = "0x79E2C0", VA = "0x18079FCC0")]
	public static void ReadTransform(this UdpPacket stream, Transform transform)
	{
	}

	// Token: 0x060002A6 RID: 678 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A6")]
	[Address(RVA = "0x79FE50", Offset = "0x79E450", VA = "0x18079FE50")]
	public static void ReadTransform(this UdpPacket stream, out Vector3 position, out Quaternion rotation)
	{
	}

	// Token: 0x060002A7 RID: 679 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A7")]
	[Address(RVA = "0x79FF40", Offset = "0x79E540", VA = "0x18079FF40")]
	public static void WriteRigidbody(this UdpPacket stream, Rigidbody rigidbody)
	{
	}

	// Token: 0x060002A8 RID: 680 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A8")]
	[Address(RVA = "0x7A01A0", Offset = "0x79E7A0", VA = "0x1807A01A0")]
	public static void ReadRigidbody(this UdpPacket stream, Rigidbody rigidbody)
	{
	}

	// Token: 0x060002A9 RID: 681 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002A9")]
	[Address(RVA = "0x7A0430", Offset = "0x79EA30", VA = "0x1807A0430")]
	public static void ReadRigidbody(this UdpPacket stream, out Vector3 position, out Quaternion rotation, out Vector3 velocity, out Vector3 angularVelocity)
	{
	}

	// Token: 0x060002AA RID: 682 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AA")]
	[Address(RVA = "0x7A05B0", Offset = "0x79EBB0", VA = "0x1807A05B0")]
	public static void WriteBounds(this UdpPacket stream, Bounds b)
	{
	}

	// Token: 0x060002AB RID: 683 RVA: 0x00002E20 File Offset: 0x00001020
	[Token(Token = "0x60002AB")]
	[Address(RVA = "0x7A0690", Offset = "0x79EC90", VA = "0x1807A0690")]
	public static Bounds ReadBounds(this UdpPacket stream)
	{
		return default(Bounds);
	}

	// Token: 0x060002AC RID: 684 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AC")]
	[Address(RVA = "0x79FA70", Offset = "0x79E070", VA = "0x18079FA70")]
	public static void WriteRect(this UdpPacket stream, Rect rect)
	{
	}

	// Token: 0x060002AD RID: 685 RVA: 0x00002E38 File Offset: 0x00001038
	[Token(Token = "0x60002AD")]
	[Address(RVA = "0x79FAE0", Offset = "0x79E0E0", VA = "0x18079FAE0")]
	public static Rect ReadRect(this UdpPacket stream)
	{
		return default(Rect);
	}

	// Token: 0x060002AE RID: 686 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002AE")]
	[Address(RVA = "0x7A0780", Offset = "0x79ED80", VA = "0x1807A0780")]
	public static void WriteRay(this UdpPacket stream, Ray ray)
	{
	}

	// Token: 0x060002AF RID: 687 RVA: 0x00002E50 File Offset: 0x00001050
	[Token(Token = "0x60002AF")]
	[Address(RVA = "0x7A0830", Offset = "0x79EE30", VA = "0x1807A0830")]
	public static Ray ReadRay(this UdpPacket stream)
	{
		return default(Ray);
	}

	// Token: 0x060002B0 RID: 688 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B0")]
	[Address(RVA = "0x7A09A0", Offset = "0x79EFA0", VA = "0x1807A09A0")]
	public static void WritePlane(this UdpPacket stream, Plane plane)
	{
	}

	// Token: 0x060002B1 RID: 689 RVA: 0x00002E68 File Offset: 0x00001068
	[Token(Token = "0x60002B1")]
	[Address(RVA = "0x7A0A20", Offset = "0x79F020", VA = "0x1807A0A20")]
	public static Plane ReadPlane(this UdpPacket stream)
	{
		return default(Plane);
	}

	// Token: 0x060002B2 RID: 690 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B2")]
	[Address(RVA = "0x7A0AC0", Offset = "0x79F0C0", VA = "0x1807A0AC0")]
	public static void WriteLayerMask(this UdpPacket stream, LayerMask mask)
	{
	}

	// Token: 0x060002B3 RID: 691 RVA: 0x00002E80 File Offset: 0x00001080
	[Token(Token = "0x60002B3")]
	[Address(RVA = "0x7A0AE0", Offset = "0x79F0E0", VA = "0x1807A0AE0")]
	public static LayerMask ReadLayerMask(this UdpPacket stream)
	{
		return default(LayerMask);
	}

	// Token: 0x060002B4 RID: 692 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B4")]
	[Address(RVA = "0x7A0B00", Offset = "0x79F100", VA = "0x1807A0B00")]
	public static void WriteMatrix4x4(this UdpPacket stream, Matrix4x4 m)
	{
	}

	// Token: 0x060002B5 RID: 693 RVA: 0x00002E98 File Offset: 0x00001098
	[Token(Token = "0x60002B5")]
	[Address(RVA = "0x7A0C30", Offset = "0x79F230", VA = "0x1807A0C30")]
	public static Matrix4x4 ReadMatrix4x4(this UdpPacket stream)
	{
		return default(Matrix4x4);
	}

	// Token: 0x060002B6 RID: 694 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B6")]
	[Address(RVA = "0x784800", Offset = "0x782E00", VA = "0x180784800")]
	public static void WriteIntVB(this UdpPacket packet, int v)
	{
	}

	// Token: 0x060002B7 RID: 695 RVA: 0x00002EB0 File Offset: 0x000010B0
	[Token(Token = "0x60002B7")]
	[Address(RVA = "0x784880", Offset = "0x782E80", VA = "0x180784880")]
	public static int ReadIntVB(this UdpPacket packet)
	{
		return 0;
	}

	// Token: 0x060002B8 RID: 696 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002B8")]
	[Address(RVA = "0x7A0D60", Offset = "0x79F360", VA = "0x1807A0D60")]
	public static void WriteUIntVB(this UdpPacket packet, uint v)
	{
	}

	// Token: 0x060002B9 RID: 697 RVA: 0x00002EC8 File Offset: 0x000010C8
	[Token(Token = "0x60002B9")]
	[Address(RVA = "0x784880", Offset = "0x782E80", VA = "0x180784880")]
	public static uint ReadUIntVB(this UdpPacket packet)
	{
		return 0U;
	}

	// Token: 0x060002BA RID: 698 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BA")]
	[Address(RVA = "0x7A0DE0", Offset = "0x79F3E0", VA = "0x1807A0DE0")]
	public static void WriteLongVB(this UdpPacket p, long v)
	{
	}

	// Token: 0x060002BB RID: 699 RVA: 0x00002EE0 File Offset: 0x000010E0
	[Token(Token = "0x60002BB")]
	[Address(RVA = "0x7A0E60", Offset = "0x79F460", VA = "0x1807A0E60")]
	public static long ReadLongVB(this UdpPacket p)
	{
		return 0L;
	}

	// Token: 0x060002BC RID: 700 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BC")]
	[Address(RVA = "0x7A0ED0", Offset = "0x79F4D0", VA = "0x1807A0ED0")]
	public static void WriteULongVB(this UdpPacket p, ulong v)
	{
	}

	// Token: 0x060002BD RID: 701 RVA: 0x00002EF8 File Offset: 0x000010F8
	[Token(Token = "0x60002BD")]
	[Address(RVA = "0x7A0E60", Offset = "0x79F460", VA = "0x1807A0E60")]
	public static ulong ReadULongVB(this UdpPacket p)
	{
		return 0UL;
	}

	// Token: 0x060002BE RID: 702 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002BE")]
	[Address(RVA = "0x7A0F50", Offset = "0x79F550", VA = "0x1807A0F50")]
	public static void WriteBoltEntity(this UdpPacket packet, BoltEntity entity)
	{
	}

	// Token: 0x060002BF RID: 703 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002BF")]
	[Address(RVA = "0x7A1030", Offset = "0x79F630", VA = "0x1807A1030")]
	public static BoltEntity ReadBoltEntity(this UdpPacket packet)
	{
		return null;
	}

	// Token: 0x060002C0 RID: 704 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C0")]
	[Address(RVA = "0x7A1050", Offset = "0x79F650", VA = "0x1807A1050")]
	internal static void WriteEntity(this UdpPacket packet, Entity entity)
	{
	}

	// Token: 0x060002C1 RID: 705 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002C1")]
	[Address(RVA = "0x7A11B0", Offset = "0x79F7B0", VA = "0x1807A11B0")]
	internal static Entity ReadEntity(this UdpPacket packet)
	{
		return null;
	}

	// Token: 0x060002C2 RID: 706 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C2")]
	[Address(RVA = "0x7A12B0", Offset = "0x79F8B0", VA = "0x1807A12B0")]
	public static void WriteNetworkId(this UdpPacket packet, NetworkId id)
	{
	}

	// Token: 0x060002C3 RID: 707 RVA: 0x00002F10 File Offset: 0x00001110
	[Token(Token = "0x60002C3")]
	[Address(RVA = "0x7A1360", Offset = "0x79F960", VA = "0x1807A1360")]
	public static NetworkId ReadNetworkId(this UdpPacket packet)
	{
		return default(NetworkId);
	}

	// Token: 0x060002C4 RID: 708 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C4")]
	[Address(RVA = "0x7A1420", Offset = "0x79FA20", VA = "0x1807A1420")]
	internal static void WriteContinueMarker(this UdpPacket stream)
	{
	}

	// Token: 0x060002C5 RID: 709 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C5")]
	[Address(RVA = "0x7A1460", Offset = "0x79FA60", VA = "0x1807A1460")]
	internal static void WriteStopMarker(this UdpPacket stream)
	{
	}

	// Token: 0x060002C6 RID: 710 RVA: 0x00002F28 File Offset: 0x00001128
	[Token(Token = "0x60002C6")]
	[Address(RVA = "0x7A14A0", Offset = "0x79FAA0", VA = "0x1807A14A0")]
	internal static bool ReadStopMarker(this UdpPacket stream)
	{
		return default(bool);
	}

	// Token: 0x060002C7 RID: 711 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C7")]
	[Address(RVA = "0x7A14E0", Offset = "0x79FAE0", VA = "0x1807A14E0")]
	private static void ByteToString(byte value, StringBuilder sb)
	{
	}

	// Token: 0x060002C8 RID: 712 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60002C8")]
	[Address(RVA = "0x7A1550", Offset = "0x79FB50", VA = "0x1807A1550")]
	private static void ByteToString(byte value, int bits, StringBuilder sb)
	{
	}

	// Token: 0x060002C9 RID: 713 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002C9")]
	[Address(RVA = "0x7A15D0", Offset = "0x79FBD0", VA = "0x1807A15D0")]
	public static string ByteToString(byte value, int bits)
	{
		return null;
	}

	// Token: 0x060002CA RID: 714 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002CA")]
	[Address(RVA = "0x7A16C0", Offset = "0x79FCC0", VA = "0x1807A16C0")]
	public static string ByteToString(byte value)
	{
		return null;
	}

	// Token: 0x060002CB RID: 715 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002CB")]
	[Address(RVA = "0x7A17A0", Offset = "0x79FDA0", VA = "0x1807A17A0")]
	public static string UShortToString(ushort value)
	{
		return null;
	}

	// Token: 0x060002CC RID: 716 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002CC")]
	[Address(RVA = "0x7A1910", Offset = "0x79FF10", VA = "0x1807A1910")]
	public static string IntToString(int value)
	{
		return null;
	}

	// Token: 0x060002CD RID: 717 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002CD")]
	[Address(RVA = "0x7A1920", Offset = "0x79FF20", VA = "0x1807A1920")]
	public static string UIntToString(uint value)
	{
		return null;
	}

	// Token: 0x060002CE RID: 718 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002CE")]
	[Address(RVA = "0x7A1B80", Offset = "0x7A0180", VA = "0x1807A1B80")]
	public static string ULongToString(ulong value)
	{
		return null;
	}

	// Token: 0x060002CF RID: 719 RVA: 0x00002052 File Offset: 0x00000252
	[Token(Token = "0x60002CF")]
	[Address(RVA = "0x7A1FA0", Offset = "0x7A05A0", VA = "0x1807A1FA0")]
	public static string BytesToString(byte[] values)
	{
		return null;
	}
}
