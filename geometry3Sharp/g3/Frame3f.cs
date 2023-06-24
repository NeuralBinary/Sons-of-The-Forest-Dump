using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020001D1 RID: 465
	[Token(Token = "0x20001D1")]
	public struct Frame3f
	{
		// Token: 0x06000D9D RID: 3485 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D9D")]
		[Address(RVA = "0x203F8F0", Offset = "0x203DEF0", VA = "0x18203F8F0")]
		public Frame3f(Frame3f copy)
		{
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D9E")]
		[Address(RVA = "0x203F910", Offset = "0x203DF10", VA = "0x18203F910")]
		public Frame3f(Vector3f origin)
		{
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000D9F")]
		[Address(RVA = "0x203F990", Offset = "0x203DF90", VA = "0x18203F990")]
		public Frame3f(Vector3d origin)
		{
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA0")]
		[Address(RVA = "0x203FA50", Offset = "0x203E050", VA = "0x18203FA50")]
		public Frame3f(Vector3f origin, Vector3f setZ)
		{
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA1")]
		[Address(RVA = "0x203FB70", Offset = "0x203E170", VA = "0x18203FB70")]
		public Frame3f(Vector3d origin, Vector3d setZ)
		{
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA2")]
		[Address(RVA = "0x203FD00", Offset = "0x203E300", VA = "0x18203FD00")]
		public Frame3f(Vector3f origin, Vector3f setAxis, int nAxis)
		{
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA3")]
		[Address(RVA = "0x203FEC0", Offset = "0x203E4C0", VA = "0x18203FEC0")]
		public Frame3f(Vector3f origin, Quaternionf orientation)
		{
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DA4")]
		[Address(RVA = "0x203FEE0", Offset = "0x203E4E0", VA = "0x18203FEE0")]
		public Frame3f(Vector3f origin, Vector3f x, Vector3f y, Vector3f z)
		{
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000DA5 RID: 3493 RVA: 0x00009CEC File Offset: 0x00007EEC
		// (set) Token: 0x06000DA6 RID: 3494 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000260")]
		public Quaternionf Rotation
		{
			[Token(Token = "0x6000DA5")]
			[Address(RVA = "0xDB80F0", Offset = "0xDB66F0", VA = "0x180DB80F0")]
			get
			{
				return default(Quaternionf);
			}
			[Token(Token = "0x6000DA6")]
			[Address(RVA = "0x16531A0", Offset = "0x16517A0", VA = "0x1816531A0")]
			set
			{
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000DA7 RID: 3495 RVA: 0x00009D04 File Offset: 0x00007F04
		// (set) Token: 0x06000DA8 RID: 3496 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x17000261")]
		public Vector3f Origin
		{
			[Token(Token = "0x6000DA7")]
			[Address(RVA = "0x1766460", Offset = "0x1764A60", VA = "0x181766460")]
			get
			{
				return default(Vector3f);
			}
			[Token(Token = "0x6000DA8")]
			[Address(RVA = "0x2040020", Offset = "0x203E620", VA = "0x182040020")]
			set
			{
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000DA9 RID: 3497 RVA: 0x00009D1C File Offset: 0x00007F1C
		[Token(Token = "0x17000262")]
		public Vector3f X
		{
			[Token(Token = "0x6000DA9")]
			[Address(RVA = "0x2040030", Offset = "0x203E630", VA = "0x182040030")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000DAA RID: 3498 RVA: 0x00009D34 File Offset: 0x00007F34
		[Token(Token = "0x17000263")]
		public Vector3f Y
		{
			[Token(Token = "0x6000DAA")]
			[Address(RVA = "0x20400C0", Offset = "0x203E6C0", VA = "0x1820400C0")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000DAB RID: 3499 RVA: 0x00009D4C File Offset: 0x00007F4C
		[Token(Token = "0x17000264")]
		public Vector3f Z
		{
			[Token(Token = "0x6000DAB")]
			[Address(RVA = "0x2040160", Offset = "0x203E760", VA = "0x182040160")]
			get
			{
				return default(Vector3f);
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00009D64 File Offset: 0x00007F64
		[Token(Token = "0x6000DAC")]
		[Address(RVA = "0x2040210", Offset = "0x203E810", VA = "0x182040210")]
		public Vector3f GetAxis(int nAxis)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DAD")]
		[Address(RVA = "0x20403C0", Offset = "0x203E9C0", VA = "0x1820403C0")]
		public void Translate(Vector3f v)
		{
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00009D7C File Offset: 0x00007F7C
		[Token(Token = "0x6000DAE")]
		[Address(RVA = "0x2040470", Offset = "0x203EA70", VA = "0x182040470")]
		public Frame3f Translated(Vector3f v)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x00009D94 File Offset: 0x00007F94
		[Token(Token = "0x6000DAF")]
		[Address(RVA = "0x2040530", Offset = "0x203EB30", VA = "0x182040530")]
		public Frame3f Translated(float fDistance, int nAxis)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB0")]
		[Address(RVA = "0x2040630", Offset = "0x203EC30", VA = "0x182040630")]
		public void Scale(float f)
		{
		}

		// Token: 0x06000DB1 RID: 3505 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB1")]
		[Address(RVA = "0x20406D0", Offset = "0x203ECD0", VA = "0x1820406D0")]
		public void Scale(Vector3f scale)
		{
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00009DAC File Offset: 0x00007FAC
		[Token(Token = "0x6000DB2")]
		[Address(RVA = "0x2040780", Offset = "0x203ED80", VA = "0x182040780")]
		public Frame3f Scaled(float f)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00009DC4 File Offset: 0x00007FC4
		[Token(Token = "0x6000DB3")]
		[Address(RVA = "0x2040830", Offset = "0x203EE30", VA = "0x182040830")]
		public Frame3f Scaled(Vector3f scale)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x20408F0", Offset = "0x203EEF0", VA = "0x1820408F0")]
		public void Rotate(Quaternionf q)
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00009DDC File Offset: 0x00007FDC
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x2040AB0", Offset = "0x203F0B0", VA = "0x182040AB0")]
		public Frame3f Rotated(Quaternionf q)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00009DF4 File Offset: 0x00007FF4
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x2040CA0", Offset = "0x203F2A0", VA = "0x182040CA0")]
		public Frame3f Rotated(float fAngle, int nAxis)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x2040DE0", Offset = "0x203F3E0", VA = "0x182040DE0")]
		public void RotateAroundAxes(Quaternionf q)
		{
		}

		// Token: 0x06000DB8 RID: 3512 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB8")]
		[Address(RVA = "0x2040FA0", Offset = "0x203F5A0", VA = "0x182040FA0")]
		public void RotateAround(Vector3f point, Quaternionf q)
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x00009E0C File Offset: 0x0000800C
		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x2041260", Offset = "0x203F860", VA = "0x182041260")]
		public Frame3f RotatedAround(Vector3f point, Quaternionf q)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x2041540", Offset = "0x203FB40", VA = "0x182041540")]
		public void AlignAxis(int nAxis, Vector3f vTo)
		{
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x2041630", Offset = "0x203FC30", VA = "0x182041630")]
		public void ConstrainedAlignAxis(int nAxis, Vector3f vTo, Vector3f vAround)
		{
		}

		// Token: 0x06000DBC RID: 3516 RVA: 0x00009E24 File Offset: 0x00008024
		[Token(Token = "0x6000DBC")]
		[Address(RVA = "0x2041800", Offset = "0x203FE00", VA = "0x182041800")]
		public Vector3f ProjectToPlane(Vector3f p, int nNormal)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DBD RID: 3517 RVA: 0x00009E3C File Offset: 0x0000803C
		[Token(Token = "0x6000DBD")]
		[Address(RVA = "0x2041970", Offset = "0x203FF70", VA = "0x182041970")]
		public Vector3f FromPlaneUV(Vector2f v, int nPlaneNormalAxis)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DBE RID: 3518 RVA: 0x00009E54 File Offset: 0x00008054
		[Token(Token = "0x6000DBE")]
		[Address(RVA = "0x2041AD0", Offset = "0x20400D0", VA = "0x182041AD0")]
		[Obsolete("replaced with FromPlaneUV")]
		public Vector3f FromFrameP(Vector2f v, int nPlaneNormalAxis)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DBF RID: 3519 RVA: 0x00009E6C File Offset: 0x0000806C
		[Token(Token = "0x6000DBF")]
		[Address(RVA = "0x2041B10", Offset = "0x2040110", VA = "0x182041B10")]
		public Vector2f ToPlaneUV(Vector3f p, int nNormal)
		{
			return default(Vector2f);
		}

		// Token: 0x06000DC0 RID: 3520 RVA: 0x00009E84 File Offset: 0x00008084
		[Token(Token = "0x6000DC0")]
		[Address(RVA = "0x2041CB0", Offset = "0x20402B0", VA = "0x182041CB0")]
		[Obsolete("Use explicit ToPlaneUV instead")]
		public Vector2f ToPlaneUV(Vector3f p, int nNormal, int nAxis0 = -1, int nAxis1 = -1)
		{
			return default(Vector2f);
		}

		// Token: 0x06000DC1 RID: 3521 RVA: 0x00009E9C File Offset: 0x0000809C
		[Token(Token = "0x6000DC1")]
		[Address(RVA = "0x2041D40", Offset = "0x2040340", VA = "0x182041D40")]
		public float DistanceToPlane(Vector3f p, int nNormal)
		{
			return 0f;
		}

		// Token: 0x06000DC2 RID: 3522 RVA: 0x00009EB4 File Offset: 0x000080B4
		[Token(Token = "0x6000DC2")]
		[Address(RVA = "0x2041E90", Offset = "0x2040490", VA = "0x182041E90")]
		public float DistanceToPlaneSigned(Vector3f p, int nNormal)
		{
			return 0f;
		}

		// Token: 0x06000DC3 RID: 3523 RVA: 0x00009ECC File Offset: 0x000080CC
		[Token(Token = "0x6000DC3")]
		[Address(RVA = "0x2041FA0", Offset = "0x20405A0", VA = "0x182041FA0")]
		public Vector3f ToFrameP(Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DC4 RID: 3524 RVA: 0x00009EE4 File Offset: 0x000080E4
		[Token(Token = "0x6000DC4")]
		[Address(RVA = "0x2042000", Offset = "0x2040600", VA = "0x182042000")]
		public Vector3f ToFrameP(ref Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DC5 RID: 3525 RVA: 0x00009EFC File Offset: 0x000080FC
		[Token(Token = "0x6000DC5")]
		[Address(RVA = "0x2042070", Offset = "0x2040670", VA = "0x182042070")]
		public Vector3d ToFrameP(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000DC6 RID: 3526 RVA: 0x00009F14 File Offset: 0x00008114
		[Token(Token = "0x6000DC6")]
		[Address(RVA = "0x20420F0", Offset = "0x20406F0", VA = "0x1820420F0")]
		public Vector3d ToFrameP(ref Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00009F2C File Offset: 0x0000812C
		[Token(Token = "0x6000DC7")]
		[Address(RVA = "0x2042170", Offset = "0x2040770", VA = "0x182042170")]
		public Vector3f FromFrameP(Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x00009F44 File Offset: 0x00008144
		[Token(Token = "0x6000DC8")]
		[Address(RVA = "0x2042290", Offset = "0x2040890", VA = "0x182042290")]
		public Vector3f FromFrameP(ref Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x00009F5C File Offset: 0x0000815C
		[Token(Token = "0x6000DC9")]
		[Address(RVA = "0x20423B0", Offset = "0x20409B0", VA = "0x1820423B0")]
		public Vector3d FromFrameP(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000DCA RID: 3530 RVA: 0x00009F74 File Offset: 0x00008174
		[Token(Token = "0x6000DCA")]
		[Address(RVA = "0x20424E0", Offset = "0x2040AE0", VA = "0x1820424E0")]
		public Vector3d FromFrameP(ref Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000DCB RID: 3531 RVA: 0x00009F8C File Offset: 0x0000818C
		[Token(Token = "0x6000DCB")]
		[Address(RVA = "0x2042630", Offset = "0x2040C30", VA = "0x182042630")]
		public Vector3f ToFrameV(Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DCC RID: 3532 RVA: 0x00009FA4 File Offset: 0x000081A4
		[Token(Token = "0x6000DCC")]
		[Address(RVA = "0x2042630", Offset = "0x2040C30", VA = "0x182042630")]
		public Vector3f ToFrameV(ref Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DCD RID: 3533 RVA: 0x00009FBC File Offset: 0x000081BC
		[Token(Token = "0x6000DCD")]
		[Address(RVA = "0x2042660", Offset = "0x2040C60", VA = "0x182042660")]
		public Vector3d ToFrameV(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000DCE RID: 3534 RVA: 0x00009FD4 File Offset: 0x000081D4
		[Token(Token = "0x6000DCE")]
		[Address(RVA = "0x2042660", Offset = "0x2040C60", VA = "0x182042660")]
		public Vector3d ToFrameV(ref Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x00009FEC File Offset: 0x000081EC
		[Token(Token = "0x6000DCF")]
		[Address(RVA = "0x2042690", Offset = "0x2040C90", VA = "0x182042690")]
		public Vector3f FromFrameV(Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x0000A004 File Offset: 0x00008204
		[Token(Token = "0x6000DD0")]
		[Address(RVA = "0x2042740", Offset = "0x2040D40", VA = "0x182042740")]
		public Vector3f FromFrameV(ref Vector3f v)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x0000A01C File Offset: 0x0000821C
		[Token(Token = "0x6000DD1")]
		[Address(RVA = "0x2042800", Offset = "0x2040E00", VA = "0x182042800")]
		public Vector3d FromFrameV(ref Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x0000A034 File Offset: 0x00008234
		[Token(Token = "0x6000DD2")]
		[Address(RVA = "0x20428D0", Offset = "0x2040ED0", VA = "0x1820428D0")]
		public Vector3d FromFrameV(Vector3d v)
		{
			return default(Vector3d);
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x0000A04C File Offset: 0x0000824C
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x2042990", Offset = "0x2040F90", VA = "0x182042990")]
		public Quaternionf ToFrame(Quaternionf q)
		{
			return default(Quaternionf);
		}

		// Token: 0x06000DD4 RID: 3540 RVA: 0x0000A064 File Offset: 0x00008264
		[Token(Token = "0x6000DD4")]
		[Address(RVA = "0x2042B70", Offset = "0x2041170", VA = "0x182042B70")]
		public Quaternionf ToFrame(ref Quaternionf q)
		{
			return default(Quaternionf);
		}

		// Token: 0x06000DD5 RID: 3541 RVA: 0x0000A07C File Offset: 0x0000827C
		[Token(Token = "0x6000DD5")]
		[Address(RVA = "0x2042D50", Offset = "0x2041350", VA = "0x182042D50")]
		public Quaternionf FromFrame(Quaternionf q)
		{
			return default(Quaternionf);
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x0000A094 File Offset: 0x00008294
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x2042F20", Offset = "0x2041520", VA = "0x182042F20")]
		public Quaternionf FromFrame(ref Quaternionf q)
		{
			return default(Quaternionf);
		}

		// Token: 0x06000DD7 RID: 3543 RVA: 0x0000A0AC File Offset: 0x000082AC
		[Token(Token = "0x6000DD7")]
		[Address(RVA = "0x20430F0", Offset = "0x20416F0", VA = "0x1820430F0")]
		public Ray3f ToFrame(Ray3f r)
		{
			return default(Ray3f);
		}

		// Token: 0x06000DD8 RID: 3544 RVA: 0x0000A0C4 File Offset: 0x000082C4
		[Token(Token = "0x6000DD8")]
		[Address(RVA = "0x20430F0", Offset = "0x20416F0", VA = "0x1820430F0")]
		public Ray3f ToFrame(ref Ray3f r)
		{
			return default(Ray3f);
		}

		// Token: 0x06000DD9 RID: 3545 RVA: 0x0000A0DC File Offset: 0x000082DC
		[Token(Token = "0x6000DD9")]
		[Address(RVA = "0x20431D0", Offset = "0x20417D0", VA = "0x1820431D0")]
		public Ray3f FromFrame(Ray3f r)
		{
			return default(Ray3f);
		}

		// Token: 0x06000DDA RID: 3546 RVA: 0x0000A0F4 File Offset: 0x000082F4
		[Token(Token = "0x6000DDA")]
		[Address(RVA = "0x20431D0", Offset = "0x20417D0", VA = "0x1820431D0")]
		public Ray3f FromFrame(ref Ray3f r)
		{
			return default(Ray3f);
		}

		// Token: 0x06000DDB RID: 3547 RVA: 0x0000A10C File Offset: 0x0000830C
		[Token(Token = "0x6000DDB")]
		[Address(RVA = "0x2043280", Offset = "0x2041880", VA = "0x182043280")]
		public Frame3f ToFrame(Frame3f f)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DDC RID: 3548 RVA: 0x0000A124 File Offset: 0x00008324
		[Token(Token = "0x6000DDC")]
		[Address(RVA = "0x2043280", Offset = "0x2041880", VA = "0x182043280")]
		public Frame3f ToFrame(ref Frame3f f)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DDD RID: 3549 RVA: 0x0000A13C File Offset: 0x0000833C
		[Token(Token = "0x6000DDD")]
		[Address(RVA = "0x2043330", Offset = "0x2041930", VA = "0x182043330")]
		public Frame3f FromFrame(Frame3f f)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x0000A154 File Offset: 0x00008354
		[Token(Token = "0x6000DDE")]
		[Address(RVA = "0x2043330", Offset = "0x2041930", VA = "0x182043330")]
		public Frame3f FromFrame(ref Frame3f f)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0000A16C File Offset: 0x0000836C
		[Token(Token = "0x6000DDF")]
		[Address(RVA = "0x20433B0", Offset = "0x20419B0", VA = "0x1820433B0")]
		public Box3f ToFrame(ref Box3f box)
		{
			return default(Box3f);
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x0000A184 File Offset: 0x00008384
		[Token(Token = "0x6000DE0")]
		[Address(RVA = "0x20434D0", Offset = "0x2041AD0", VA = "0x1820434D0")]
		public Box3f FromFrame(ref Box3f box)
		{
			return default(Box3f);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0000A19C File Offset: 0x0000839C
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0x20435C0", Offset = "0x2041BC0", VA = "0x1820435C0")]
		public Box3d ToFrame(ref Box3d box)
		{
			return default(Box3d);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x0000A1B4 File Offset: 0x000083B4
		[Token(Token = "0x6000DE2")]
		[Address(RVA = "0x2043710", Offset = "0x2041D10", VA = "0x182043710")]
		public Box3d FromFrame(ref Box3d box)
		{
			return default(Box3d);
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x0000A1CC File Offset: 0x000083CC
		[Token(Token = "0x6000DE3")]
		[Address(RVA = "0x2043820", Offset = "0x2041E20", VA = "0x182043820")]
		public Vector3f RayPlaneIntersection(Vector3f ray_origin, Vector3f ray_direction, int nAxisAsNormal)
		{
			return default(Vector3f);
		}

		// Token: 0x06000DE4 RID: 3556 RVA: 0x0000A1E4 File Offset: 0x000083E4
		[Token(Token = "0x6000DE4")]
		[Address(RVA = "0x2043AD0", Offset = "0x20420D0", VA = "0x182043AD0")]
		public static Frame3f Interpolate(Frame3f f1, Frame3f f2, float t)
		{
			return default(Frame3f);
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x0000A1FC File Offset: 0x000083FC
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x2043C90", Offset = "0x2042290", VA = "0x182043C90")]
		public bool EpsilonEqual(Frame3f f2, float epsilon)
		{
			return default(bool);
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000DE6")]
		[Address(RVA = "0x2043D20", Offset = "0x2042320", VA = "0x182043D20", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x6000DE7")]
		[Address(RVA = "0x2043D60", Offset = "0x2042360", VA = "0x182043D60")]
		public string ToString(string fmt)
		{
			return null;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x0000A214 File Offset: 0x00008414
		[Token(Token = "0x6000DE8")]
		[Address(RVA = "0x2044260", Offset = "0x2042860", VA = "0x182044260")]
		public static Frame3f SolveMinRotation(Frame3f source, Frame3f target)
		{
			return default(Frame3f);
		}

		// Token: 0x04000767 RID: 1895
		[Token(Token = "0x4000767")]
		[FieldOffset(Offset = "0x0")]
		private Quaternionf rotation;

		// Token: 0x04000768 RID: 1896
		[Token(Token = "0x4000768")]
		[FieldOffset(Offset = "0x10")]
		private Vector3f origin;

		// Token: 0x04000769 RID: 1897
		[Token(Token = "0x4000769")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Frame3f Identity;
	}
}
