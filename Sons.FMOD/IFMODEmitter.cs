using System;
using Il2CppDummyDll;

// Token: 0x02000014 RID: 20
[Token(Token = "0x2000014")]
public interface IFMODEmitter
{
	// Token: 0x06000073 RID: 115
	[Token(Token = "0x6000073")]
	void EnableEmitter(bool value);

	// Token: 0x06000074 RID: 116
	[Token(Token = "0x6000074")]
	void DestroyEmitter();

	// Token: 0x06000075 RID: 117
	[Token(Token = "0x6000075")]
	void Stop();

	// Token: 0x06000076 RID: 118
	[Token(Token = "0x6000076")]
	void Play();

	// Token: 0x06000077 RID: 119
	[Token(Token = "0x6000077")]
	void SetEventPath(string eventPath);
}
