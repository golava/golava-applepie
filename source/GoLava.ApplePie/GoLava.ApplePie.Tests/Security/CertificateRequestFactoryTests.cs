﻿using GoLava.ApplePie.Security;
using Xunit;

namespace GoLava.ApplePie.Tests.Security
{
    public class CertificateRequestFactoryTests
    {
        [Fact]
        public void CreateCertificateRequestWithPrivateKeyReturnsNotNull()
        {
            var certificateRequestWithPrivateKey = this.CreateCertificateRequestWithPrivateKey();
            Assert.NotNull(certificateRequestWithPrivateKey);
        }

        [Fact]
        public void CreateCertificateRequestWithPrivateKeyReturnsValidCertificateRequest()
        {
            var certificateRequestWithPrivateKey = this.CreateCertificateRequestWithPrivateKey();
            Assert.NotEmpty(certificateRequestWithPrivateKey.CertificateRequest);
        }

        [Fact]
        public void CreateCertificateRequestWithPrivateKeyReturnsValidPrivateKey()
        {
            var certificateRequestWithPrivateKey = this.CreateCertificateRequestWithPrivateKey();
            Assert.NotEmpty(certificateRequestWithPrivateKey.PrivateKey);
        }

        [Fact]
        public void CreateCertificateRequestWithPrivateKeyReturnsValidPublicKey()
        {
            var certificateRequestWithPrivateKey = this.CreateCertificateRequestWithPrivateKey();
            Assert.NotEmpty(certificateRequestWithPrivateKey.PublicKey);
        }

        private CertificateRequestWithPrivateKey CreateCertificateRequestWithPrivateKey()
        {
            var certificateRequestFactory = new CertificateRequestFactory();
            return certificateRequestFactory.CreateCertificateRequestWithPrivateKey();
        }
    }
}