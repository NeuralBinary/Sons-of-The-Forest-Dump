using System;
using Bolt;
using Il2CppDummyDll;
using UnityEngine;

// Token: 0x02000018 RID: 24
[Token(Token = "0x2000018")]
[Documentation]
public class BoltHitbox : MonoBehaviour
{
	// Token: 0x1700001F RID: 31
	// (get) Token: 0x060000BD RID: 189 RVA: 0x00002268 File Offset: 0x00000468
	// (set) Token: 0x060000BE RID: 190 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x1700001F")]
	public BoltHitboxShape hitboxShape
	{
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x5FD580", Offset = "0x5FBB80", VA = "0x1805FD580")]
		get
		{
			return BoltHitboxShape.Box;
		}
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x5FD590", Offset = "0x5FBB90", VA = "0x1805FD590")]
		set
		{
		}
	}

	// Token: 0x17000020 RID: 32
	// (get) Token: 0x060000BF RID: 191 RVA: 0x00002280 File Offset: 0x00000480
	// (set) Token: 0x060000C0 RID: 192 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000020")]
	public BoltHitboxType hitboxType
	{
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x7814F0", Offset = "0x77FAF0", VA = "0x1807814F0")]
		get
		{
			return BoltHitboxType.Unknown;
		}
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x781500", Offset = "0x77FB00", VA = "0x180781500")]
		set
		{
		}
	}

	// Token: 0x17000021 RID: 33
	// (get) Token: 0x060000C1 RID: 193 RVA: 0x00002298 File Offset: 0x00000498
	// (set) Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000021")]
	public Vector3 hitboxCenter
	{
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x781510", Offset = "0x77FB10", VA = "0x180781510")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x781530", Offset = "0x77FB30", VA = "0x180781530")]
		set
		{
		}
	}

	// Token: 0x17000022 RID: 34
	// (get) Token: 0x060000C3 RID: 195 RVA: 0x000022B0 File Offset: 0x000004B0
	// (set) Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000022")]
	public Vector3 hitboxBoxSize
	{
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x781540", Offset = "0x77FB40", VA = "0x180781540")]
		get
		{
			return default(Vector3);
		}
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x781560", Offset = "0x77FB60", VA = "0x180781560")]
		set
		{
		}
	}

	// Token: 0x17000023 RID: 35
	// (get) Token: 0x060000C5 RID: 197 RVA: 0x000022C8 File Offset: 0x000004C8
	// (set) Token: 0x060000C6 RID: 198 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x17000023")]
	public float hitboxSphereRadius
	{
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570")]
		get
		{
			return 0f;
		}
		[Token(Token = "0x60000C6")]
		[Address(RVA = "0x781580", Offset = "0x77FB80", VA = "0x180781580")]
		set
		{
		}
	}

	// Token: 0x060000C7 RID: 199 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C7")]
	[Address(RVA = "0x781590", Offset = "0x77FB90", VA = "0x180781590")]
	private void OnDrawGizmos()
	{
	}

	// Token: 0x060000C8 RID: 200 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000C8")]
	[Address(RVA = "0x7816B0", Offset = "0x77FCB0", VA = "0x1807816B0")]
	internal void Draw(Matrix4x4 matrix)
	{
	}

	// Token: 0x060000C9 RID: 201 RVA: 0x000022E0 File Offset: 0x000004E0
	[Token(Token = "0x60000C9")]
	[Address(RVA = "0x781970", Offset = "0x77FF70", VA = "0x180781970")]
	internal bool OverlapSphere(ref Matrix4x4 matrix, Vector3 center, float radius)
	{
		return default(bool);
	}

	// Token: 0x060000CA RID: 202 RVA: 0x000022F8 File Offset: 0x000004F8
	[Token(Token = "0x60000CA")]
	[Address(RVA = "0x781C90", Offset = "0x780290", VA = "0x180781C90")]
	internal bool Raycast(ref Matrix4x4 matrix, Vector3 origin, Vector3 direction, out float distance)
	{
		return default(bool);
	}

	// Token: 0x060000CB RID: 203 RVA: 0x00002310 File Offset: 0x00000510
	[Token(Token = "0x60000CB")]
	[Address(RVA = "0x782150", Offset = "0x780750", VA = "0x180782150")]
	private bool OverlapSphereOnSphere(Vector3 center, float radius)
	{
		return default(bool);
	}

	// Token: 0x060000CC RID: 204 RVA: 0x00002328 File Offset: 0x00000528
	[Token(Token = "0x60000CC")]
	[Address(RVA = "0x782250", Offset = "0x780850", VA = "0x180782250")]
	private bool OverlapSphereOnBox(Vector3 center, float radius)
	{
		return default(bool);
	}

	// Token: 0x060000CD RID: 205 RVA: 0x00002340 File Offset: 0x00000540
	[Token(Token = "0x60000CD")]
	[Address(RVA = "0x7823F0", Offset = "0x7809F0", VA = "0x1807823F0")]
	private bool RaycastSphere(Vector3 o, Vector3 d, out float distance)
	{
		return default(bool);
	}

	// Token: 0x060000CE RID: 206 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CE")]
	[Address(RVA = "0x782570", Offset = "0x780B70", VA = "0x180782570")]
	private static void ClampVector(ref Vector3 value, ref Vector3 min, ref Vector3 max, out Vector3 result)
	{
	}

	// Token: 0x060000CF RID: 207 RVA: 0x00002050 File Offset: 0x00000250
	[Token(Token = "0x60000CF")]
	[Address(RVA = "0x7825D0", Offset = "0x780BD0", VA = "0x1807825D0")]
	public BoltHitbox()
	{
	}

	// Token: 0x04000052 RID: 82
	[Token(Token = "0x4000052")]
	[FieldOffset(Offset = "0x20")]
	[SerializeField]
	internal BoltHitboxShape _shape;

	// Token: 0x04000053 RID: 83
	[Token(Token = "0x4000053")]
	[FieldOffset(Offset = "0x24")]
	[SerializeField]
	internal BoltHitboxType _type;

	// Token: 0x04000054 RID: 84
	[Token(Token = "0x4000054")]
	[FieldOffset(Offset = "0x28")]
	[SerializeField]
	internal Vector3 _center;

	// Token: 0x04000055 RID: 85
	[Token(Token = "0x4000055")]
	[FieldOffset(Offset = "0x34")]
	[SerializeField]
	internal Vector3 _boxSize;

	// Token: 0x04000056 RID: 86
	[Token(Token = "0x4000056")]
	[FieldOffset(Offset = "0x40")]
	[SerializeField]
	internal float _sphereRadius;
}
