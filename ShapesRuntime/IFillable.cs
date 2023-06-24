using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Shapes
{
	// Token: 0x02000053 RID: 83
	[Token(Token = "0x2000053")]
	public interface IFillable
	{
		// Token: 0x170001B3 RID: 435
		// (get) Token: 0x06000BA5 RID: 2981
		// (set) Token: 0x06000BA6 RID: 2982
		[Token(Token = "0x170001B3")]
		GradientFill Fill { [Token(Token = "0x6000BA5")] get; [Token(Token = "0x6000BA6")] set; }

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06000BA7 RID: 2983
		// (set) Token: 0x06000BA8 RID: 2984
		[Token(Token = "0x170001B4")]
		bool UseFill { [Token(Token = "0x6000BA7")] get; [Token(Token = "0x6000BA8")] set; }

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000BA9 RID: 2985
		// (set) Token: 0x06000BAA RID: 2986
		[Token(Token = "0x170001B5")]
		FillType FillType { [Token(Token = "0x6000BA9")] get; [Token(Token = "0x6000BAA")] set; }

		// Token: 0x170001B6 RID: 438
		// (get) Token: 0x06000BAB RID: 2987
		// (set) Token: 0x06000BAC RID: 2988
		[Token(Token = "0x170001B6")]
		FillSpace FillSpace { [Token(Token = "0x6000BAB")] get; [Token(Token = "0x6000BAC")] set; }

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000BAD RID: 2989
		// (set) Token: 0x06000BAE RID: 2990
		[Token(Token = "0x170001B7")]
		Vector3 FillRadialOrigin { [Token(Token = "0x6000BAD")] get; [Token(Token = "0x6000BAE")] set; }

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000BAF RID: 2991
		// (set) Token: 0x06000BB0 RID: 2992
		[Token(Token = "0x170001B8")]
		float FillRadialRadius { [Token(Token = "0x6000BAF")] get; [Token(Token = "0x6000BB0")] set; }

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000BB1 RID: 2993
		// (set) Token: 0x06000BB2 RID: 2994
		[Token(Token = "0x170001B9")]
		Vector3 FillLinearStart { [Token(Token = "0x6000BB1")] get; [Token(Token = "0x6000BB2")] set; }

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000BB3 RID: 2995
		// (set) Token: 0x06000BB4 RID: 2996
		[Token(Token = "0x170001BA")]
		Vector3 FillLinearEnd { [Token(Token = "0x6000BB3")] get; [Token(Token = "0x6000BB4")] set; }

		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000BB5 RID: 2997
		// (set) Token: 0x06000BB6 RID: 2998
		[Token(Token = "0x170001BB")]
		Color FillColorStart { [Token(Token = "0x6000BB5")] get; [Token(Token = "0x6000BB6")] set; }

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000BB7 RID: 2999
		// (set) Token: 0x06000BB8 RID: 3000
		[Token(Token = "0x170001BC")]
		Color FillColorEnd { [Token(Token = "0x6000BB7")] get; [Token(Token = "0x6000BB8")] set; }
	}
}
