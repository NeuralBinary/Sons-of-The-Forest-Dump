using System;
using Backtrace.Unity.Model.Attributes;
using Il2CppDummyDll;

namespace Backtrace.Unity.Runtime.Native
{
	// Token: 0x02000021 RID: 33
	[Token(Token = "0x2000021")]
	internal interface INativeClient : IDynamicAttributeProvider
	{
		// Token: 0x06000118 RID: 280
		[Token(Token = "0x6000118")]
		void HandleAnr();

		// Token: 0x06000119 RID: 281
		[Token(Token = "0x6000119")]
		void SetAttribute(string key, string value);

		// Token: 0x0600011A RID: 282
		[Token(Token = "0x600011A")]
		bool OnOOM();

		// Token: 0x0600011B RID: 283
		[Token(Token = "0x600011B")]
		void Update(float time);

		// Token: 0x0600011C RID: 284
		[Token(Token = "0x600011C")]
		void Disable();

		// Token: 0x0600011D RID: 285
		[Token(Token = "0x600011D")]
		void PauseAnrThread(bool state);
	}
}
