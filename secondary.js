const pulumi = require("@pulumi/pulumi");
const aws = require("@pulumi/aws");
class SC extends pulumi.ComponentResource {
    constructor(name, config, opts) {
        var inputs = {
            options: opts,
        };
        super(name, inputs, opts);

        let scGroup = new aws.ec2.SecurityGroup("Security_Group", {
            egress: [{
                fromPort: 0,
                toPort: 0,
                protocol: "-1",
                cidrBlocks: ["0.0.0.0/0"],
                ipv6CidrBlocks: ["::/0"],
                }],
            ingress: [
                {
                    description: "TLS from VPC",
                    fromPort: 80,
                    toPort: 80,
                    protocol: "tcp",
                    cidrBlocks: ["0.0.0.0/0"],
                }],
            ingress: [
                { description: "TLS from VPC",
                fromPort: 443,
                toPort: 443,
                protocol: "tcp",
                cidrBlocks: ["0.0.0.0/0"],
                }],
            ingress: [
                { description: "TLS from VPC",
                fromPort: 22,
                toPort: 22,
                protocol: "tcp",
                cidrBlocks: ["0.0.0.0/0"],
                }],
                tags: {
                    Name: "antoan-intern-ec02-lb",
                },
            });
        
 }};

 module.exports = SC;
