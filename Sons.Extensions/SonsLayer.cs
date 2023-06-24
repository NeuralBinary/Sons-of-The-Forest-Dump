using System;
using Il2CppDummyDll;

namespace Sons.Extensions
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	public class SonsLayer
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5EDA40", Offset = "0x5EC040", VA = "0x1805EDA40")]
		private SonsLayer(int value)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002100 File Offset: 0x00000300
		[Token(Token = "0x6000018")]
		[Address(RVA = "0x2FCAA90", Offset = "0x2FC9090", VA = "0x182FCAA90")]
		public static implicit operator int(SonsLayer layer)
		{
			return 0;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000019")]
		[Address(RVA = "0x2FCAAB0", Offset = "0x2FC90B0", VA = "0x182FCAAB0")]
		public static implicit operator SonsLayer(int layerValue)
		{
			return null;
		}

		// Token: 0x04000016 RID: 22
		[Token(Token = "0x4000016")]
		[FieldOffset(Offset = "0x10")]
		private readonly int _value;

		// Token: 0x04000017 RID: 23
		[Token(Token = "0x4000017")]
		[FieldOffset(Offset = "0x0")]
		public static readonly SonsLayer Default;

		// Token: 0x04000018 RID: 24
		[Token(Token = "0x4000018")]
		[FieldOffset(Offset = "0x8")]
		public static readonly SonsLayer TransparentFX;

		// Token: 0x04000019 RID: 25
		[Token(Token = "0x4000019")]
		[FieldOffset(Offset = "0x10")]
		public static readonly SonsLayer IgnoreRaycast;

		// Token: 0x0400001A RID: 26
		[Token(Token = "0x400001A")]
		[FieldOffset(Offset = "0x18")]
		public static readonly SonsLayer BasicTrigger;

		// Token: 0x0400001B RID: 27
		[Token(Token = "0x400001B")]
		[FieldOffset(Offset = "0x20")]
		public static readonly SonsLayer Water;

		// Token: 0x0400001C RID: 28
		[Token(Token = "0x400001C")]
		[FieldOffset(Offset = "0x28")]
		public static readonly SonsLayer UI;

		// Token: 0x0400001D RID: 29
		[Token(Token = "0x400001D")]
		[FieldOffset(Offset = "0x30")]
		public static readonly SonsLayer ShadowsOnly;

		// Token: 0x0400001E RID: 30
		[Token(Token = "0x400001E")]
		[FieldOffset(Offset = "0x38")]
		public static readonly SonsLayer TreeWS;

		// Token: 0x0400001F RID: 31
		[Token(Token = "0x400001F")]
		[FieldOffset(Offset = "0x40")]
		public static readonly SonsLayer HUD;

		// Token: 0x04000020 RID: 32
		[Token(Token = "0x4000020")]
		[FieldOffset(Offset = "0x48")]
		public static readonly SonsLayer BushWS;

		// Token: 0x04000021 RID: 33
		[Token(Token = "0x4000021")]
		[FieldOffset(Offset = "0x50")]
		public static readonly SonsLayer CullingMedium;

		// Token: 0x04000022 RID: 34
		[Token(Token = "0x4000022")]
		[FieldOffset(Offset = "0x58")]
		public static readonly SonsLayer GreebleSmall;

		// Token: 0x04000023 RID: 35
		[Token(Token = "0x4000023")]
		[FieldOffset(Offset = "0x60")]
		public static readonly SonsLayer CullingFar;

		// Token: 0x04000024 RID: 36
		[Token(Token = "0x4000024")]
		[FieldOffset(Offset = "0x68")]
		public static readonly SonsLayer CullingNone;

		// Token: 0x04000025 RID: 37
		[Token(Token = "0x4000025")]
		[FieldOffset(Offset = "0x70")]
		public static readonly SonsLayer ImpactDetect;

		// Token: 0x04000026 RID: 38
		[Token(Token = "0x4000026")]
		[FieldOffset(Offset = "0x78")]
		public static readonly SonsLayer Held;

		// Token: 0x04000027 RID: 39
		[Token(Token = "0x4000027")]
		[FieldOffset(Offset = "0x80")]
		public static readonly SonsLayer Ragdoll;

		// Token: 0x04000028 RID: 40
		[Token(Token = "0x4000028")]
		[FieldOffset(Offset = "0x88")]
		public static readonly SonsLayer Pusher;

		// Token: 0x04000029 RID: 41
		[Token(Token = "0x4000029")]
		[FieldOffset(Offset = "0x90")]
		public static readonly SonsLayer Player;

		// Token: 0x0400002A RID: 42
		[Token(Token = "0x400002A")]
		[FieldOffset(Offset = "0x98")]
		public static readonly SonsLayer Character;

		// Token: 0x0400002B RID: 43
		[Token(Token = "0x400002B")]
		[FieldOffset(Offset = "0xA0")]
		public static readonly SonsLayer Wall;

		// Token: 0x0400002C RID: 44
		[Token(Token = "0x400002C")]
		[FieldOffset(Offset = "0xA8")]
		public static readonly SonsLayer Prop;

		// Token: 0x0400002D RID: 45
		[Token(Token = "0x400002D")]
		[FieldOffset(Offset = "0xB0")]
		public static readonly SonsLayer BasicCollider;

		// Token: 0x0400002E RID: 46
		[Token(Token = "0x400002E")]
		[FieldOffset(Offset = "0xB8")]
		public static readonly SonsLayer Inventory;

		// Token: 0x0400002F RID: 47
		[Token(Token = "0x400002F")]
		[FieldOffset(Offset = "0xC0")]
		public static readonly SonsLayer Poke;

		// Token: 0x04000030 RID: 48
		[Token(Token = "0x4000030")]
		[FieldOffset(Offset = "0xC8")]
		public static readonly SonsLayer Blocker;

		// Token: 0x04000031 RID: 49
		[Token(Token = "0x4000031")]
		[FieldOffset(Offset = "0xD0")]
		public static readonly SonsLayer Terrain;

		// Token: 0x04000032 RID: 50
		[Token(Token = "0x4000032")]
		[FieldOffset(Offset = "0xD8")]
		public static readonly SonsLayer Camera;

		// Token: 0x04000033 RID: 51
		[Token(Token = "0x4000033")]
		[FieldOffset(Offset = "0xE0")]
		public static readonly SonsLayer PickUp;

		// Token: 0x04000034 RID: 52
		[Token(Token = "0x4000034")]
		[FieldOffset(Offset = "0xE8")]
		public static readonly SonsLayer Grab;

		// Token: 0x04000035 RID: 53
		[Token(Token = "0x4000035")]
		[FieldOffset(Offset = "0xF0")]
		public static readonly SonsLayer SmallDynamic;

		// Token: 0x04000036 RID: 54
		[Token(Token = "0x4000036")]
		[FieldOffset(Offset = "0xF8")]
		public static readonly SonsLayer noCollide;

		// Token: 0x04000037 RID: 55
		[Token(Token = "0x4000037")]
		[FieldOffset(Offset = "0x100")]
		public static readonly SonsLayer[] AllLayers;
	}
}
