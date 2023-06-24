using System;
using Il2CppDummyDll;

namespace Bolt
{
	// Token: 0x020000D4 RID: 212
	[Token(Token = "0x20000D4")]
	internal struct PropertyTransformCompressionSettings
	{
		// Token: 0x06000673 RID: 1651 RVA: 0x00004260 File Offset: 0x00002460
		[Token(Token = "0x6000673")]
		[Address(RVA = "0x8FE830", Offset = "0x8FCE30", VA = "0x1808FE830")]
		public static PropertyTransformCompressionSettings Create(PropertyVectorCompressionSettings position, PropertyQuaternionCompression rotation)
		{
			return default(PropertyTransformCompressionSettings);
		}

		// Token: 0x040002F2 RID: 754
		[Token(Token = "0x40002F2")]
		[FieldOffset(Offset = "0x0")]
		public PropertyVectorCompressionSettings Position;

		// Token: 0x040002F3 RID: 755
		[Token(Token = "0x40002F3")]
		[FieldOffset(Offset = "0x34")]
		public PropertyQuaternionCompression Rotation;
	}
}
